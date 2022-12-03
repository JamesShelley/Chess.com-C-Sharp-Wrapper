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

            internal static string GET_PLAYER_CLUBS(string playerName) => $"{GET_PLAYER_PROFILE_DATA}/{playerName}/clubs";


            internal static string GET_PLAYER_MONTHLY_ARCHIVES(string playerName, string YYYY, string MM) =>
          $"/pub/player/{playerName}/games/{YYYY}/{MM}";

            #endregion

            #region CLUB ENDPOINTS

            internal static string GET_CLUB_DETAILS(string clubName) => $"/pub/club/{clubName}";

            internal static string GET_CLUB_MEMBERS(string clubName) => $"/pub/club/{clubName}/members";

            #endregion

            #region STREAMER ENDPOINTS

            internal static string GET_STREAMERS = "/pub/streamers";

            #endregion

            #region TOURNAMENT ENDPOINTS

            internal static string GET_TOURNAMENT(string tournamentName) => $"/pub/tournament/{tournamentName}";
            internal static string GET_TOURNAMENT_ROUND(string tournamentName, int round) => $"/pub/tournament/{tournamentName}/{round}";
            internal static string GET_TOURNAMENT_ROUND_GROUP(string tournamentName, int round, int group) => $"/pub/tournament/{tournamentName}/{round}/{group}";

            #endregion

            #region PUZZLE ENDPOINTS

            internal static string GET_DAILY_PUZZLE = "/pub/puzzle";
            internal static string GET_RANDOM_PUZZLE = "/pub/puzzle/random";

            #endregion
        }

        #endregion

        #region lichess.org endpoints

        internal static class LiChess
        {
            #region ACCOUNT endpoints

            internal static string GET_MY_PROFILE = "/api/account";
            internal static string GET_MY_EMAIL_ADDRESS = "/api/account/email";
            internal static string GET_MY_PREFERENCES = "/api/account/preferences";

            #endregion
        }

        #endregion
    }
}
