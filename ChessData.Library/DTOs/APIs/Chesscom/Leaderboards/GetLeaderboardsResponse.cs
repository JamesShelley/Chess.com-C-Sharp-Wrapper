using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ChessData.Library.DTOs.APIs.Chesscom.Leaderboards
{
    public sealed class GetLeaderboardsResponse
    {
        [JsonPropertyName("daily")]
        public List<LeaderboardItemDto>? Daily { get; set; }
        [JsonPropertyName("daily960")]
        public List<LeaderboardItemDto>? Daily960 { get; set; }
        [JsonPropertyName("live_rapid")]
        public List<LeaderboardItemDto>? LiveRapid { get; set; }
        [JsonPropertyName("live_blitz")]
        public List<LeaderboardItemDto>? LiveBlitz { get; set; }
        [JsonPropertyName("live_bullet")]
        public List<LeaderboardItemDto>? LiveBullet { get; set; }
        [JsonPropertyName("live_bughouse")]
        public List<LeaderboardItemDto>? LiveBughouse { get; set; }
        [JsonPropertyName("live_blitz960")]
        public List<LeaderboardItemDto>? LiveBlitz960 { get; set; }
        [JsonPropertyName("live_threecheck")]
        public List<LeaderboardItemDto>? LiveThreeCheck { get; set; }
        [JsonPropertyName("live_crazyhouse")]
        public List<LeaderboardItemDto>? LiveCrazyHouse { get; set; }
        [JsonPropertyName("live_kingofthehill")]
        public List<LeaderboardItemDto>? LiveKingOfTheHill { get; set; }
        [JsonPropertyName("tactics")]
        public List<LeaderboardItemDto>? Tactics { get; set; }
        [JsonPropertyName("rush")]
        public List<LeaderboardItemDto>? Rush { get; set; }
        [JsonPropertyName("battle")]
        public List<LeaderboardItemDto>? Battle { get; set; }

        public class LeaderboardItemDto
        {
            public long PlayerId { get; set; }
           
            [JsonPropertyName("@id")]
            public string? Id { get; set; }
            public string? Url { get; set; }
            public string? Username { get; set; }
            public int Score { get; set; }
            public int Rank { get; set; }
            public string? Country { get; set; }
            public string? Title { get; set; }
            public string? Name { get; set; }
            public string? Status { get; set; }
            public string? Avatar { get; set; }
            public TrendItemDto? TrendItem { get; set; }
            public TrendItemDto? TrendRank { get; set; }
            public string? FlairCode { get; set; }
            public int WinCount { get; set; }
            public int LossCount { get; set; }
            public int DrawCount { get; set; }
        }

        public class TrendItemDto
        {
            public int Direction { get; set; }
            public int Trend { get; set; }
        }
    }
}
