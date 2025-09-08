using System.Text.Json.Serialization;

namespace PrivateServerClient.Core.Models.PlayerScores;

public class ScoreClan
{
    [JsonPropertyName("id")]
    public int? ClanID { get; set; }

    [JsonPropertyName("name")]
    public string? ClanName { get; set; }

    [JsonPropertyName("tag")]
    public string? ClanTag { get; set; }
}
