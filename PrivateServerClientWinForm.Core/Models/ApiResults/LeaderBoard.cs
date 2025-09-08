using PrivateServerClient.Core.Models.Leaderboard;
using System.Text.Json.Serialization;

namespace PrivateServerClient.Core.Models.ApiResults;

public class LeaderBoard
{
    [JsonPropertyName("status")]
    public string ResponseStatus { get; set; } = string.Empty;

    [JsonPropertyName("leaderboard")]
    public List<LeaderboardUser> LeaderboardUsers { get; set; } = new List<LeaderboardUser>();
}
