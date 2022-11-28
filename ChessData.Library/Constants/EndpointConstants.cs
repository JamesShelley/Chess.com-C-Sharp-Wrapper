namespace ChessData.Library.Constants
{
    internal static class EndpointConstants
    {
        #region chess.com endpoints
        internal static class ChessCom
        {
            #region BASE ENDPOINTS

            internal static readonly string GET_TITLED_PLAYERS = "/pub/titled";

            internal static readonly string GET_PLAYER_PROFILE_DATA = "/pub/player";

            internal static readonly string GET_LEADERBOARDS = "/pub/leaderboards";

            #endregion

            #region PLAYER ENDPOINTS

            internal static string GET_PLAYER_STATS_DATA(string playerName) => $"{GET_PLAYER_PROFILE_DATA}/{playerName}/stats";

            internal static string GET_PLAYER_TOURNAMENTS(string playerName) => $"{GET_PLAYER_PROFILE_DATA}/{playerName}/tournaments";

            internal static string GET_PLAYER_DAILY_GAMES(string playerName) => $"{GET_PLAYER_PROFILE_DATA}/{playerName}/games";

            internal static string GET_PLAYER_MONTHLY_ARCHIVES(string playerName, string YYYY, string MM) =>
          $"/pub/player/{playerName}/games/{YYYY}/{MM}";

            #endregion

            #region CLUB ENDPOINTS

            internal static string GET_CLUB_DETAILS(string clubName) => $"/pub/club/{clubName}";

            internal static string GET_CLUB_MEMBERS(string clubName) => $"/pub/club/{clubName}/members";

            #endregion

            #region STREAMER endpoints

            internal static string GET_STREAMERS = "/pub/streamers";

            #endregion

        }

        #endregion

        #region lichess.org endpoints

        internal static class LiChess
        {
            internal static string ACCOUNT = "/api/account";
        }

        #endregion
    }
}
