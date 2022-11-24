namespace ChessData.Library.DTOs.APIs.Chesscom.Common
{
    public interface IBaseChessGameProperties
    {
        public string? Url { get; set; }
        public string? Pgn { get; set; }
        public string? Fen { get; set; }
    }
}
