namespace ChessData.Library.DTOs.APIs.Chesscom.Players
{
    public sealed class GetPlayerDailyGamesResponse
    {
        public List<PlayerGameDto>? Games { get; set; }

        public class PlayerGameDto
        {
            public string? Url { get; set; }
            public long MoveBy { get; set; }
            public string? Pgn { get; set; }
            public string? TimeControl { get; set; }
            public long LastActivity { get; set; }
            public bool Rated { get; set; }
            public string? Turn { get; set; }
            public string? Fen { get; set; }
            public long StartTime { get; set; }
            public string? TimeClass { get; set; }
            public string? Rules { get; set; }
            public string? White { get; set; }
            public string? Black { get; set; }
        }
    }
}
