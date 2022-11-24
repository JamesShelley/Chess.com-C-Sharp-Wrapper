using ChesscomAPI.Library.Constants;
using ChesscomAPI.Library.Core.Json;
using ChesscomAPI.Library.DTOs.Players;
using ChesscomAPI.Library.DTOs.Streamers;
using ChesscomAPI.Library.Interfaces;
using ChesscomAPI.Library.Models;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

namespace ChesscomAPI.Library.Core
{
    /// <summary>
    /// Our service class which interacts with the Chess.com api
    /// </summary>
    /// <remarks>
    /// For example, inject this into your constructor and access by _chessClient.GetPlayerProfileData("erik")
    /// </remarks>
    internal sealed class ChesscomApi : IChesscomApi
    {
        private readonly HttpClient _httpClient;
        public ChesscomApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        #region Player Endpoints

        /// <summary>
        /// Get additional details about a player in a game.
        /// </summary>
        /// <param name="playerName">The name of the player you want to get information for.</param>
        /// <returns>A <c>PlayerDataDetailsDto</c> object</returns>
        public async Task<ApiResponse<GetPlayerProfileDataResponse?>> GetPlayerProfileData(string playerName)
        {
            ArgumentException.ThrowIfNullOrEmpty(playerName, nameof(playerName));
            return await BuildApiResponse<GetPlayerProfileDataResponse?>($"{EndpointConstants.GET_PLAYER_PROFILE_DATA}/{playerName}");
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
            return await BuildApiResponse<GetTitledPlayersResponse?>($"{EndpointConstants.GET_TITLED_PLAYERS}/{title.ToUpper()}");
        }


        /// <summary>
        ///  Get ratings, win/loss, and other stats about a player's game play, tactics, lessons and Puzzle Rush score
        /// </summary>
        /// <param name="playerName">The name of the player who you want statistics of.</param>
        /// <returns>A <c>PlayerDataDetailsDto</c> object</returns>
        public async Task<ApiResponse<GetPlayerStatsDataResponse?>> GetPlayerStatsData(string playerName)
        {
            ArgumentException.ThrowIfNullOrEmpty(playerName, nameof(playerName));
            return await BuildApiResponse<GetPlayerStatsDataResponse?>($"{EndpointConstants.GET_PLAYER_STATS_DATA(playerName)}");
        }

        /// <summary>
        /// List of tournaments the player is registered, is attending or has attended in the past.
        /// </summary>
        /// <param name="playerName">The name of the player who you want statistics of.</param>
        /// <returns>A <c>PlayerDataDetailsDto</c> object</returns>
        public async Task<ApiResponse<GetPlayerTournamentsResponse?>> GetPlayerTournaments(string playerName)
        {
            ArgumentException.ThrowIfNullOrEmpty(playerName, nameof(playerName));
            return await BuildApiResponse<GetPlayerTournamentsResponse?>($"{EndpointConstants.GET_PLAYER_TOURNAMENTS(playerName)}");
        }

        #endregion

        #region Streamer Endpoints

        /// <summary>
        /// Displays information about top 50 player for daily and live games, tactics and lessons.
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<GetStreamersResponse?>> GetStreamers()
        {
            return await BuildApiResponse<GetStreamersResponse?>($"{EndpointConstants.GET_STREAMERS}");
        }

        #endregion

        #region Private Methods
        /// <summary>
        /// Builds our Api response
        /// </summary>
        /// <typeparam name="T">The type we want to try too deserialze our json too</typeparam>
        /// <param name="endpoint">The chess.com api endpoint we are targetting</param>
        /// <returns>An <c>ApiResponse<typeparamref name="T"/></c>object</returns>
        private async Task<ApiResponse<T>> BuildApiResponse<T>(string endpoint)
        {
            var response = new ApiResponse<T?>();
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = SnakeCaseNamingPolicy.Instance
            };

            try
            {
                var apiResponse = await _httpClient.GetAsync(endpoint);
                apiResponse.EnsureSuccessStatusCode();
                response.ResponseStatusCode = apiResponse.StatusCode;
                response.ResponseMessage = apiResponse.ReasonPhrase;
                response.ResponseData = await apiResponse.Content.ReadFromJsonAsync<T>(options);
            }
            catch (HttpRequestException ex)
            {
                response.ResponseStatusCode = ex.StatusCode;
                response.ResponseMessage = $"Error: {ex.InnerException?.Message}";
            }
            catch (Exception ex)
            {
                response.ResponseStatusCode = HttpStatusCode.InternalServerError;
                response.ResponseMessage = $"Error {ex.InnerException?.Message}";
            }
            return response;
        }

        #endregion
    }

}
