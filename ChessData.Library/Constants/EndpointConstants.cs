namespace ChessData.Library.Constants
{
    internal static class EndpointConstants
    {
        internal static class ChessCom
        {
            internal static readonly string GET_TITLED_PLAYERS = "/pub/titled";

            internal static readonly string GET_PLAYER_PROFILE_DATA = "/pub/player";
            internal static string GET_PLAYER_STATS_DATA(string name)
            {
                return $"{GET_PLAYER_PROFILE_DATA}/{name}/stats";
            }

            internal static string GET_PLAYER_TOURNAMENTS(string name)
            {
                return $"{GET_PLAYER_PROFILE_DATA}/{name}/tournaments";
            }

            internal static string GET_PLAYER_DAILY_GAMES(string name)
            {
                return $"{GET_PLAYER_PROFILE_DATA}/{name}/games";
            }

            internal static string GET_STREAMERS = "/pub/streamers";
        }

        internal static class LiChess
        {
            internal static string ACCOUNT = "/api/account";
        }
    }
}
