using System.Text.Json.Serialization;

namespace PrivateServerClient.Core.Models.Leaderboard;

public class LeaderboardUser
{
    [JsonPropertyName("player_id")]
    public int PlayerId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("country")]
    public string Country { get; set; } = string.Empty;

    [JsonPropertyName("tscore")]
    public ulong TotalScore { get; set; }

    [JsonPropertyName("rscore")]
    public ulong RankedScore { get; set; }

    [JsonPropertyName("pp")]
    public ulong TotalPP { get; set; }

    [JsonPropertyName("plays")]
    public int PlayCount { get; set; }

    [JsonPropertyName("playtime")]
    public int PlayTime { get; set; }

    [JsonPropertyName("acc")]
    public double Accuracy { get; set; }

    [JsonPropertyName("max_combo")]
    public int MaxCombo { get; set; }

    [JsonPropertyName("xh_count")]
    public int CountXH { get; set; }

    [JsonPropertyName("x_count")]
    public int CountX { get; set; }

    [JsonPropertyName("sh_count")]
    public int CountSH { get; set; }

    [JsonPropertyName("s_count")]
    public int CountS { get; set; }

    [JsonPropertyName("a_count")]
    public int CountA { get; set; }

    [JsonPropertyName("clan_id")]
    public int? ClanID { get; set; }

    [JsonPropertyName("clan_name")]
    public string? ClanName { get; set; }

    [JsonPropertyName("clan_tag")]
    public string? ClanTag { get; set; }
}
