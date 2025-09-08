using System.Text.Json.Serialization;

namespace PrivateServerClient.Core.Models.PlayerScores;

public class Beatmap
{
    [JsonPropertyName("md5")]
    public string Md5 { get; set; } = string.Empty;

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("set_id")]
    public int SetId { get; set; }

    [JsonPropertyName("artist")]
    public string Artist { get; set; } = string.Empty;

    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("version")]
    public string Version { get; set; } = string.Empty;

    [JsonPropertyName("creator")]
    public string Creator { get; set; } = string.Empty;

    [JsonPropertyName("last_update")]
    public DateTime LastUpdate { get; set; }

    [JsonPropertyName("total_length")]
    public int TotalLength { get; set; }

    [JsonPropertyName("max_combo")]
    public int MaxCombo { get; set; }

    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("plays")]
    public int Plays { get; set; }

    [JsonPropertyName("passes")]
    public int Passes { get; set; }

    [JsonPropertyName("mode")]
    public int Mode { get; set; }

    [JsonPropertyName("bpm")]
    public double Bpm { get; set; }

    [JsonPropertyName("cs")]
    public double CircleSize { get; set; }

    [JsonPropertyName("od")]
    public double OverallDifficulty { get; set; }

    [JsonPropertyName("ar")]
    public double ApproachRate { get; set; }

    [JsonPropertyName("hp")]
    public double HpDrain { get; set; }

    [JsonPropertyName("diff")]
    public double Difficulty { get; set; }
}
