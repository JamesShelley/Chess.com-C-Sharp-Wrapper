namespace ChessData.Library.Constants
{
    internal static class EndpointConstants
    {
        internal static class ChessCom
        {
            internal static readonly string GET_TITLED_PLAYERS = "/pub/titled";

            internal static readonly string GET_PLAYER_PROFILE_DATA = "/pub/player";

            internal static readonly string GET_LEADERBOARDS = "/pub/leaderboards";

            internal static string GET_STREAMERS = "/pub/streamers";

            internal static string GET_PLAYER_STATS_DATA(string playerName) => $"{GET_PLAYER_PROFILE_DATA}/{playerName}/stats";

            internal static string GET_PLAYER_TOURNAMENTS(string playerName) => $"{GET_PLAYER_PROFILE_DATA}/{playerName}/tournaments";

            internal static string GET_PLAYER_DAILY_GAMES(string playerName) => $"{GET_PLAYER_PROFILE_DATA}/{playerName}/games";

            internal static string GET_CLUB_DETAILS(string clubName) => $"/pub/club/{clubName}";

            internal static string GET_PLAYER_MONTHLY_ARCHIVES(string playerName, string YYYY, string MM) =>
                $"/pub/player/{playerName}/games/{YYYY}/{MM}";
        }

        internal static class LiChess
        {
            internal static string ACCOUNT = "/api/account";
        }
    }
}
