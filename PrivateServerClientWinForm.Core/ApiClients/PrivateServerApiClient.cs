using PrivateServerClient.Core.Models;
using PrivateServerClient.Core.Models.ApiResults;
using PrivateServerClient.Core.Models.Leaderboard;
using PrivateServerClient.Core.Services;
using System.Text.Json;

namespace PrivateServerClient.Core.ApiClients;

public class PrivateServerApiClient(PrivateServer privateServer)
{
    private readonly PrivateServer _privateServer = privateServer;

    private readonly HttpClient _httpClient = new();
    private static readonly JsonSerializerOptions jsonSerializerOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    async public Task<List<LeaderboardUser>?> GetLeaderBoard(int mode)
    {
        try
        {
            var url = new UrlBuilder()
                .WithBase(_privateServer.ServerApiAddressV1)
                .WithPath("/get_leaderboard")
                .AddQuery("mode", mode)
                .Build();

            var response = await _httpClient.GetStringAsync(url);

            var leaderBoardData = JsonSerializer.Deserialize<LeaderBoard>(response, jsonSerializerOptions);
            if (leaderBoardData?.ResponseStatus != "success") return null;

            return leaderBoardData?.LeaderboardUsers;
        } 
        catch (Exception ex)
        {
            Console.WriteLine("データの取得に失敗しました。\n" + ex);
            return null;
        }
    }

    async public Task<PlayerScores?> GetBestPerformance(string id, int mode)
    {
        try
        {
            var url = new UrlBuilder()
                .WithBase(_privateServer.ServerApiAddressV1)
                .WithPath("/get_player_scores")
                .AddQuery("scope", "best")
                .AddQuery("mode", mode)
                .AddQuery("id", id)
                .AddQuery("limit", 50)
                .Build();

            var response = await _httpClient.GetStringAsync(url);

            var bestPerformanceData = JsonSerializer.Deserialize<PlayerScores>(response, jsonSerializerOptions);
            if (bestPerformanceData?.ResponseStatus != "success") return null;

            return bestPerformanceData;
        }
        catch (Exception ex)
        {
            Console.WriteLine("データの取得に失敗しました。\n" + ex);
            return null;
        }
    }

    async public Task<PlayerScores?> GetPlayingHistory(string id, int mode)
    {
        try
        {
            var url = new UrlBuilder()
                .WithBase(_privateServer.ServerApiAddressV1)
                .WithPath("/get_player_scores")
                .AddQuery("scope", "recent")
                .AddQuery("mode", mode)
                .AddQuery("id", id)
                .AddQuery("limit", 50)
                .Build();

            var response = await _httpClient.GetStringAsync(url);

            var playingHistoryData = JsonSerializer.Deserialize<PlayerScores>(response, jsonSerializerOptions);
            if (playingHistoryData?.ResponseStatus != "success") return null;

            return playingHistoryData;
        }
        catch (Exception ex)
        {
            Console.WriteLine("データの取得に失敗しました。\n" + ex);
            return null;
        }
    }
}
