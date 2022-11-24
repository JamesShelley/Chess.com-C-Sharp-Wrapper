using ChessData.Library.Core.Json;
using ChessData.Library.Constants;
using ChessData.Library.DTOs.APIs.Chesscom.Players;
using ChessData.Library.DTOs.APIs.Chesscom.Streamers;
using ChessData.Library.Interfaces;
using ChessData.Library.Models;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

namespace ChessData.Library.Core.APIs
{
    /// <summary>
    /// Our service class which interacts with the Chess.com api
    /// </summary>
    /// <remarks>
    /// For example, inject this into your constructor and access by _chessClient.GetPlayerProfileData("erik")
    /// </remarks>
    internal sealed class ChesscomApi : ApiResponseBuilder, IChesscomApi
    {
        
        //Chess.com API works with snakecase
        static JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = SnakeCaseNamingPolicy.Instance
        };

        public ChesscomApi(HttpClient httpClient) : base(httpClient,options) { }

        #region Player Endpoints

        /// <summary>
        /// Get additional details about a player in a game.
        /// </summary>
        /// <param name="playerName">The name of the player you want to get information for.</param>
        /// <returns>A <c>PlayerDataDetailsDto</c> object</returns>
        public async Task<ApiResponse<GetPlayerProfileDataResponse?>> GetPlayerProfileData(string playerName)
        {
            ArgumentException.ThrowIfNullOrEmpty(playerName, nameof(playerName));
            return await BuildApiResponse<GetPlayerProfileDataResponse?>($"{EndpointConstants.ChessCom.GET_PLAYER_PROFILE_DATA}/{playerName}");
        }

        /// <summary>
        /// Gets a List of titled-player usernames.
        /// </summary>
        /// <param name="title">See the static <c>ChessTitles</c> class for available title filters</param>
        /// <returns>An object of type <c>GetTitledPlayersResponse</c></returns>
        /// <remarks>For example, pass in the paramer "gm" to get a list of al grandmasters</remarks>
        public async Task<ApiResponse<GetTitledPlayersResponse?>> GetTitledPlayers(string title)
        {
            ArgumentException.ThrowIfNullOrEmpty(title);
            //Chess.com API titles have to be in upper case. ¯\_(ツ)_/¯
            return await BuildApiResponse<GetTitledPlayersResponse?>($"{EndpointConstants.ChessCom.GET_TITLED_PLAYERS}/{title.ToUpper()}");
        }


        /// <summary>
        ///  Get ratings, win/loss, and other stats about a player's game play, tactics, lessons and Puzzle Rush score
        /// </summary>
        /// <param name="playerName">The name of the player who you want statistics of.</param>
        /// <returns>A <c>PlayerDataDetailsDto</c> object</returns>
        public async Task<ApiResponse<GetPlayerStatsDataResponse?>> GetPlayerStatsData(string playerName)
        {
            ArgumentException.ThrowIfNullOrEmpty(playerName, nameof(playerName));
            return await BuildApiResponse<GetPlayerStatsDataResponse?>($"{EndpointConstants.ChessCom.GET_PLAYER_STATS_DATA(playerName)}");
        }

        /// <summary>
        /// List of tournaments the player is registered, is attending or has attended in the past.
        /// </summary>
        /// <param name="playerName">The name of the player who you want statistics of.</param>
        /// <returns>A <c>PlayerDataDetailsDto</c> object</returns>
        public async Task<ApiResponse<GetPlayerTournamentsResponse?>> GetPlayerTournaments(string playerName)
        {
            ArgumentException.ThrowIfNullOrEmpty(playerName, nameof(playerName));
            return await BuildApiResponse<GetPlayerTournamentsResponse?>($"{EndpointConstants.ChessCom.GET_PLAYER_TOURNAMENTS(playerName)}");
        }

        /// <summary>
        /// Array of Daily Chess games that a player is currently playing.
        /// </summary>
        /// <param name="playerName">The name of the player who you want statistics of.</param>
        /// <returns>A <c>PlayerDataDetailsDto</c> object</returns>
        public async Task<ApiResponse<GetPlayerDailyGamesResponse?>> GetPlayerDailyGames(string playerName)
        {
            ArgumentException.ThrowIfNullOrEmpty(playerName, nameof(playerName));
            return await BuildApiResponse<GetPlayerDailyGamesResponse?>($"{EndpointConstants.ChessCom.GET_PLAYER_DAILY_GAMES(playerName)}");
        }

        #endregion

        #region Streamer Endpoints

        /// <summary>
        /// Displays information about top 50 player for daily and live games, tactics and lessons.
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<GetStreamersResponse?>> GetStreamers()
        {
            return await BuildApiResponse<GetStreamersResponse?>($"{EndpointConstants.ChessCom.GET_STREAMERS}");
        }

        #endregion
    }

}
