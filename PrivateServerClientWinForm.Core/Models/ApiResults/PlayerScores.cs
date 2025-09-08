using PrivateServerClient.Core.Models.PlayerScores;
using System.Text.Json.Serialization;

namespace PrivateServerClient.Core.Models.ApiResults;

public class PlayerScores
{
    [JsonPropertyName("status")]
    public string ResponseStatus { get; set; } = string.Empty;

    [JsonPropertyName("scores")]
    public List<Score> Scores { get; set; } = new();

    [JsonPropertyName("player")]
    public ScoreUser Player { get; set; } = new();
}
