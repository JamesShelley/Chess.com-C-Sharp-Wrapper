using ChessData.Library.DTOs.APIs.Chesscom.Common;

namespace ChessData.Library.DTOs.APIs.Chesscom.Players
{
    public class GetPlayerMonthlyArchivesResponse
    {
        public List<ArchivedGameDto>? Games { get; set; }

        public class ArchivedGameDto : IBaseChessGameProperties
        {
            public string? Url { get; set; }
            public string? Pgn { get; set; }
            public string? TimeControl { get; set; }
            public long EndTime { get; set; }
            public bool Rated { get; set; }
            public string? Tcn { get; set; }
            public string? Uuid { get; set; }
            public string? InitialSetup { get; set; }
            public string? Fen { get; set; }
            public long? StartTime { get; set; }
            public string? TimeClass { get; set; }
            public string? Rules { get; set; }
            public GameResultDto? White { get; set; }
            public GameResultDto? Black { get; set; }

        }

    }
}
