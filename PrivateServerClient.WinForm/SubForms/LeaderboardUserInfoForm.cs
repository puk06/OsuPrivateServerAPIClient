using PrivateServerClient.Core.Models.Leaderboard;
using PrivateServerClient.WinForm.Utils;

namespace PrivateServerClient.WinForm.SubForms;

public partial class LeaderboardUserInfoForm : Form
{
    public LeaderboardUserInfoForm(LeaderboardUser leaderboardUser)
    {
        InitializeComponent();
        SetValueFromUser(leaderboardUser);
    }

    public void SetValueFromUser(LeaderboardUser leaderboardUser)
    {
        usernameLabel.Text = TextUtils.CheckString(leaderboardUser.Name);
        countryLabel.Text = $"{TextUtils.CheckString(leaderboardUser.Country.ToUpper())}";
        if (!string.IsNullOrEmpty(leaderboardUser.ClanTag)) countryLabel.Text += $" / {leaderboardUser.ClanTag}";

        playerStatsLabel.Text = $"{leaderboardUser.RankedScore}\n{leaderboardUser.Accuracy:F2}%\n{leaderboardUser.PlayCount}\n{leaderboardUser.TotalScore}\n{leaderboardUser.MaxCombo}";
        additionalStatsLabel.Text = $"合計PP: {leaderboardUser.TotalPP}";

        Text = $"Player Info for {TextUtils.CheckString(leaderboardUser.Name)}";
    }
}
