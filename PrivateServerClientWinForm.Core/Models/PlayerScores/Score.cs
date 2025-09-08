using System.Text.Json.Serialization;

namespace PrivateServerClient.Core.Models.PlayerScores;

public class Score
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("score")]
    public int TotalScore { get; set; }

    [JsonPropertyName("pp")]
    public double PerformancePoints { get; set; }

    [JsonPropertyName("acc")]
    public double Accuracy { get; set; }

    [JsonPropertyName("max_combo")]
    public int MaxCombo { get; set; }

    [JsonPropertyName("mods")]
    public int Mods { get; set; }

    [JsonPropertyName("n300")]
    public int Count300 { get; set; }

    [JsonPropertyName("n100")]
    public int Count100 { get; set; }

    [JsonPropertyName("n50")]
    public int Count50 { get; set; }

    [JsonPropertyName("nmiss")]
    public int Misses { get; set; }

    [JsonPropertyName("ngeki")]
    public int CountGeki { get; set; }

    [JsonPropertyName("nkatu")]
    public int CountKatu { get; set; }

    [JsonPropertyName("grade")]
    public string Grade { get; set; } = string.Empty;

    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("mode")]
    public int Mode { get; set; }

    [JsonPropertyName("play_time")]
    public DateTime PlayTime { get; set; }

    [JsonPropertyName("time_elapsed")]
    public int TimeElapsed { get; set; }

    [JsonPropertyName("perfect")]
    public int Perfect { get; set; }

    [JsonPropertyName("beatmap")]
    public Beatmap Beatmap { get; set; } = new();
}
