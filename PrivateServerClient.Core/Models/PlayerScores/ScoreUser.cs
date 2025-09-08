using System.Text.Json.Serialization;

namespace PrivateServerClient.Core.Models.PlayerScores;

public class ScoreUser
{
    [JsonPropertyName("id")]
    public int PlayerId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("clan")]
    public ScoreClan ScoreClan { get; set; } = new();
}
