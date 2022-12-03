using System.Text.Json.Serialization;

namespace ChessData.Library.DTOs.APIs.Chesscom.Tournaments
{
    public sealed class GetTournamentRoundGroupResponse
    {
        ////list of username accounts closed for fair play violation
        public List<string>? FairPlayRemovals { get; set; }

        public List<TournamentRoundGroupGamesDto>? Games { get; set; }

        public List<TournamentRoundGroupPlayersDto>? Players { get; set; }

        public sealed class TournamentRoundGroupGamesDto
        {
            public string? Url { get; set; }
            public string? Pgn { get; set; }
            public string? TimeControl { get; set; }
            public long? EndTime { get; set; }
            public bool Rated { get; set; }
            public string? Fen { get; set; }
            public long StartTime { get; set; }
            public string? TimeClass { get; set; }
            public string? Rules { get; set; }
            public TournamentRoundGroupPlayerPieceColourDto? White { get; set; }
            public TournamentRoundGroupPlayerPieceColourDto? Black { get; set; }
            public string? Tournament { get; set; }
        }

         public sealed class TournamentRoundGroupPlayersDto
        {
            public string? Username { get; set; }
            public decimal Points { get; set; }
            public bool IsAdvancing { get; set; }
            public decimal TieBreak { get; set; }
        }

        public sealed class TournamentRoundGroupPlayerPieceColourDto
        {
            public int Rating { get; set; }
            public string? Result { get; set; }
            [JsonPropertyName("@id")]
            public string? Id { get; set; }
            public string? Username { get; set; }
            public string? Uuid { get; set; }
        }
    }
}