namespace ChessData.Library.DTOs.APIs.Chesscom.Tournaments
{
    public sealed class GetTournamentRoundResponse
    {
        public List<string>? Groups { get; set; }
        public List<TournamentRoundPlayerDto>? Players { get; set; }

        public sealed class TournamentRoundPlayerDto 
        {
            public string? Username { get; set; }
            public bool IsAdvancing { get; set; }
        }
    }
}