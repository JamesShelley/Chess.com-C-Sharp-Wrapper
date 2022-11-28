namespace ChessData.Library.DTOs.APIs.Chesscom.Common
{
    public class PuzzleResponseDto : IBaseChessGameProperties
    {
        public string? Url { get; set; }
        public string? Pgn { get; set; }
        public string? Fen { get; set; }
        public string? Title { get; set; }
        public long PublishTime { get; set; }
        public string? Image { get; set; }
    }
}
