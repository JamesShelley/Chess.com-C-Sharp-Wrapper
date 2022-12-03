namespace ChessData.Library.DTOs.APIs.Chesscom.Tournaments
{
    public sealed class GetTournamentResponse
    {
        public string? Name { get; set; }
        public string? Url { get; set; } 
        public string? Description { get; set; }
        public string? Creator { get; set; }
        public string? Status { get; set; }
        public long FinishTime { get; set; }
        public TournamentSettingsDto? Settings { get; set; }
        public List<TournamentPlayersDto>? Players { get; set; }
        public List<string>? Rounds { get; set; }

        public class TournamentSettingsDto
        {
            public string? Type { get; set; }
            public string? Rules { get; set; }
            public bool IsRated { get; set; }
            public bool IsOfficial { get; set; }
            public bool IsInviteOnly { get; set; }
            public int MinRating { get; set; }
            public int MaxRating { get; set; }
            public int InitialGroupSize { get; set; }
            public int UserAdvanceCount { get; set; }
            public bool UseTiebreak { get; set; }
            public bool AllowVacation { get; set; }
            public int WinnerPlaces { get; set; }
            public int RegisteredUserCount { get; set; }
            public int GamesPerOpponent { get; set; }
            public int TotalRounds { get; set; }
            public int ConcurrentGamesPerOpponent { get; set; }
            public string? TimeClass { get; set; }
            public string? TimeControl { get; set; }
        }

        public class TournamentPlayersDto
        {
            public string? Name { get; set;}
            public string? Status { get; set; }
        }
    }
}
