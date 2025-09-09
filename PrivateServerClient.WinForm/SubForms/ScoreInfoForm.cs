using PrivateServerClient.Core.Models.PlayerScores;
using PrivateServerClient.WinForm.Utils;

namespace PrivateServerClient.WinForm.SubForms;

public partial class ScoreInfoForm : Form
{
    public ScoreInfoForm(Score score)
    {
        InitializeComponent();
        SetValueFromUser(score);
    }

    public void SetValueFromUser(Score score)
    {
        songNameLabel.Text = TextUtils.CheckString(score.Beatmap.Title);
        starsLabel.Text = $"★{score.Beatmap.Difficulty:F2}  [{TextUtils.CheckString(score.Beatmap.Version)}]  作者 {TextUtils.CheckString(score.Beatmap.Creator)}";

        scoreStatsLabel.Text = $"{score.Accuracy:F2}%\n{score.MaxCombo}\n{score.Count300}\n{score.Count100}\n{score.Count50}\n{score.Misses}";
        ppLabel.Text = $"{score.PerformancePoints}pp";

        Text = $"Score Info for ID: {score.Id}";
    }
}
