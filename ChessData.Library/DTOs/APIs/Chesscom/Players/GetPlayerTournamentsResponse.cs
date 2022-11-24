using System.Text.Json.Serialization;

namespace ChessData.Library.DTOs.APIs.Chesscom.Players
{
    public sealed class GetPlayerTournamentsResponse
    {

        public List<TournamentResponseDto>? Finished { get; set; }
        public List<TournamentResponseDto>? InProgress { get; set; }
        public List<TournamentResponseDto>? Registered { get; set; }

        public class TournamentResponseDto
        {
            public string? Url { get; set; }
            [JsonPropertyName("@id")]
            public string? Id { get; set; }
            public int Wins { get; set; }
            public int Losses { get; set; }
            public int Draws { get; set; }
            public int PointsAwarded { get; set; }
            public int Placement { get; set; }
            public string? Status { get; set; }
            public int TotalPlayers { get; set; }
        }

    }
}
