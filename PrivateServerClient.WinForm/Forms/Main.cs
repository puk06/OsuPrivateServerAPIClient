using PrivateServerClient.Core.ApiClients;
using PrivateServerClient.Core.Models;
using PrivateServerClient.Core.Models.ApiResults;
using PrivateServerClient.Core.Models.Leaderboard;
using PrivateServerClient.Core.Models.PlayerScores;
using PrivateServerClient.WinForm.SubForms;

namespace PrivateServerClient.WinForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            modeComboBox.SelectedIndex = 0;
        }

        private DateTime _lastAccessToApi = DateTime.MinValue;

        private List<LeaderboardUser> _leaderboardUsers = new();
        private PlayerScores _playerBestPerformanceData = new();
        private PlayerScores _playerPlayingHistoryData = new();

        #region Event Handlers
        private void GetLeaderboardDataButton_Click(object sender, EventArgs e)
            => GetLeadboardData();

        private void GetUserDataButton_Click(object sender, EventArgs e)
            => GetUserData();

        private void GlobalLeaderboardList_MouseDown(object sender, MouseEventArgs e)
        {
            int clickedIndex = globalLeaderboardList.IndexFromPoint(e.Location);
            if (clickedIndex < 0 || clickedIndex >= _leaderboardUsers.Count) return;

            LeaderboardUser selectedUser = _leaderboardUsers[clickedIndex];
            LeaderboardUserInfoForm leaderboardUserInfoForm = new(selectedUser);
            leaderboardUserInfoForm.Show();


            globalLeaderboardList.SelectedIndex = -1;
        }

        private void BestPerformanceList_MouseDown(object sender, MouseEventArgs e)
        {
            int clickedIndex = bestPerformanceList.IndexFromPoint(e.Location) - 1;
            if (clickedIndex < 0 || clickedIndex >= _playerBestPerformanceData.Scores.Count) return;

            Score selectedScore = _playerBestPerformanceData.Scores[clickedIndex];
            ScoreInfoForm scoreInfoForm = new(selectedScore);
            scoreInfoForm.Show();

            bestPerformanceList.SelectedIndex = -1;
        }

        private void PlayingHistoryList_MouseDown(object sender, MouseEventArgs e)
        {
            int clickedIndex = playingHistoryList.IndexFromPoint(e.Location) - 1;
            if (clickedIndex < 0 || clickedIndex >= _playerBestPerformanceData.Scores.Count) return;

            Score selectedScore = _playerBestPerformanceData.Scores[clickedIndex];
            ScoreInfoForm scoreInfoForm = new(selectedScore);
            scoreInfoForm.Show();

            playingHistoryList.SelectedIndex = -1;
        }
        #endregion

        #region Get Data
        async private void GetLeadboardData()
        {
            if (!CheckInterval()) return;
            if (!CheckText(serverEndpoint.Text, "サーバー")) return;

            var privateServer = new PrivateServer(serverEndpoint.Text);
            var privateServerClient = new PrivateServerApiClient(privateServer);

            var leaderboardUsers = await privateServerClient.GetLeaderBoard(modeComboBox.SelectedIndex);
            if (leaderboardUsers == null)
            {
                MessageBox.Show("リーダーボードデータの取得に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _leaderboardUsers = leaderboardUsers;
            }

            GenerateLeaderboard();
        }

        async private void GetUserData()
        {
            if (!CheckInterval()) return;
            if (!CheckText(serverEndpoint.Text, "サーバー") || !CheckText(userIdBox.Text, "ユーザーID")) return;

            var privateServer = new PrivateServer(serverEndpoint.Text);
            var privateServerClient = new PrivateServerApiClient(privateServer);

            var bestPerformanceData = await privateServerClient.GetBestPerformance(userIdBox.Text, modeComboBox.SelectedIndex);
            if (bestPerformanceData == null)
            {
                MessageBox.Show("PPデータの取得に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _playerBestPerformanceData = bestPerformanceData;
            }

            var playingHistoryData = await privateServerClient.GetPlayingHistory(userIdBox.Text, modeComboBox.SelectedIndex);
            if (playingHistoryData == null)
            {
                MessageBox.Show("プレイ履歴データの取得に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _playerPlayingHistoryData = playingHistoryData;
            }

            GenerateUserBestPerformance();
            GenerateUserPlayingHistory();
        }
        #endregion

        #region Generate Lists
        private void GenerateLeaderboard()
        {
            globalLeaderboardList.Items.Clear();

            for (int i = 0; i < _leaderboardUsers.Count; i++)
            {
                LeaderboardUser user = _leaderboardUsers[i];

                if (!string.IsNullOrEmpty(user.ClanTag))
                {
                    globalLeaderboardList.Items.Add($"#{i + 1}  |  {user.TotalPP}pp - [{user.ClanTag}] {user.Name} (ID: {user.PlayerId})");
                }
                else
                {
                    globalLeaderboardList.Items.Add($"#{i + 1}  |  {user.TotalPP}pp - {user.Name} (ID: {user.PlayerId})");
                }
            }
        }

        private void GenerateUserBestPerformance()
        {
            bestPerformanceList.Items.Clear();

            bestPerformanceList.Items.Add($"   -  {modeComboBox.Text} Best Performance for {_playerBestPerformanceData.Player.Name}   -   ");

            for (int i = 0; i < _playerBestPerformanceData.Scores.Count; i++)
            {
                Score score = _playerBestPerformanceData.Scores[i];
                bestPerformanceList.Items.Add($"#{i + 1}  |  ★{score.Beatmap.Difficulty:F2} - {score.PerformancePoints:F}pp - {score.Accuracy:F2}% - {score.Beatmap.Title} by {score.Beatmap.Artist} ({score.Beatmap.Version})");
            }
        }

        private void GenerateUserPlayingHistory()
        {
            playingHistoryList.Items.Clear();

            playingHistoryList.Items.Add($"   -  {modeComboBox.Text} Playing History for {_playerPlayingHistoryData.Player.Name}   -   ");

            for (int i = 0; i < _playerPlayingHistoryData.Scores.Count; i++)
            {
                Score score = _playerPlayingHistoryData.Scores[i];
                playingHistoryList.Items.Add($"#{i + 1}  |  {score.Grade} - {score.PerformancePoints:F}pp - {score.Accuracy:F2}% - {score.Beatmap.Title} by {score.Beatmap.Artist} ({score.Beatmap.Version})");
            }
        }
        #endregion

        private bool CheckInterval()
        {
            var currentTime = DateTime.Now;
            if (_lastAccessToApi.AddSeconds(2) > currentTime)
            {
                MessageBox.Show("更新の間隔が短すぎます。前回の取得から2秒以上空けてください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            _lastAccessToApi = currentTime;
            return true;
        }

        private static bool CheckText(string text, string name)
        {
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show($"{name}欄を空白にすることは出来ません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}