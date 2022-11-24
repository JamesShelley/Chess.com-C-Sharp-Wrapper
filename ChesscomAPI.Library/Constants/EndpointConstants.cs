namespace ChesscomAPI.Library.Constants
{
    internal static class EndpointConstants
    {
        internal static readonly string GET_TITLED_PLAYERS = "/pub/titled";

        internal static readonly string GET_PLAYER_PROFILE_DATA = "/pub/player";
        internal static string GET_PLAYER_STATS_DATA(string name)
        {
            return $"{GET_PLAYER_PROFILE_DATA}/{name}/stats";
        }

        internal static string GET_STREAMERS = "/pub/streamers";
    }
}
