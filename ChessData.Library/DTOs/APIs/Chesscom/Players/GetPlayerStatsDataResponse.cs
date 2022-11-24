using System.Text.Json.Serialization;

namespace ChessData.Library.DTOs.APIs.Chesscom.Players
{
    public sealed class GetPlayerStatsDataResponse
    {
        public ChessStatsDto? ChessDaily { get; set; }
        [JsonPropertyName("chess960_daily")]
        public ChessStatsDto? Chess960Daily { get; set; }
        public ChessStatsDto? ChessRapid { get; set; }
        public ChessStatsDto? ChessBullet { get; set; }
        public ChessStatsDto? ChessBlitz { get; set; }
        public int Fide { get; set; }
        public ChessStatsPuzzleRush? PuzzleRush { get; set; }

        public class ChessStatsDto
        {
            public ChessStatsLastRatingDto? Last { get; set; }
            public ChessStatsBestRatingDto? Best { get; set; }
            public ChessStatsRecordDto? Record { get; set; }
            public ChessStatsTournamentDto? Tournament { get; set; }
            public ChessStatsTactics? Tactics { get; set; }
        }

        public class ChessStatsLastRatingDto
        {
            public int Rating { get; set; }
            public long Date { get; set; }
            public int Rd { get; set; }
        }

        public class ChessStatsBestRatingDto
        {
            public int Rating { get; set; }
            public long Date { get; set; }
            public string? Game { get; set; }
        }

        public class ChessStatsRecordDto
        {
            public int Win { get; set; }
            public int Loss { get; set; }
            public int Draw { get; set; }
            public int TimePerMove { get; set; }
            public int TimeoutPercent { get; set; }
        }

        public class ChessStatsTournamentDto
        {
            public int Points { get; set; }
            public int Withdraw { get; set; }
            public int Count { get; set; }
            public int HighestFinish { get; set; }
        }

        public class ChessStatsTactics
        {
            public ChessStatsTacticsDto? Highest { get; set; }
            public ChessStatsTacticsDto? Lowest { get; set; }

        }

        public class ChessStatsTacticsDto
        {
            public int Rating { get; set; }
            public long Date { get; set; }
        }

        public class ChessStatsPuzzleRush
        {
            public ChessStatsPuzzleRushDto? Best { get; set; }
        }

        public class ChessStatsPuzzleRushDto
        {
            public int TotalAttempts { get; set; }
            public int Score { get; set; }
        }
    }
}
