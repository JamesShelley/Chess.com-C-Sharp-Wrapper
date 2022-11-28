﻿using ChessData.Library.Core.Json;
using ChessData.Library.Constants;
using ChessData.Library.DTOs.APIs.Chesscom.Players;
using ChessData.Library.DTOs.APIs.Chesscom.Streamers;
using ChessData.Library.Interfaces;
using ChessData.Library.Models;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using ChessData.Library.DTOs.APIs.Chesscom.Clubs;
using ChessData.Library.DTOs.APIs.Chesscom.Leaderboards;
using static System.Reflection.Metadata.BlobBuilder;
using System;

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

        /// <summary>
        /// Array of Live and Daily Chess games that a player has finished.
        /// </summary>
        /// <param name="playerName">The name of the player who you want statistics of.</param>
        /// <param name="year">The year, in format YYYY, e.g. 2020</param>
        /// <param name="month">The month, in format MM, e.g. 12</param>
        /// <returns></returns>
        public async Task<ApiResponse<GetPlayerMonthlyArchivesResponse?>> GetPlayerMonthlyGameArchives(string playerName, string year, string month)
        {
            ArgumentException.ThrowIfNullOrEmpty(playerName, nameof(playerName));
            ArgumentException.ThrowIfNullOrEmpty(year, nameof(year));
            ArgumentException.ThrowIfNullOrEmpty(month, nameof(month));

            return await BuildApiResponse<GetPlayerMonthlyArchivesResponse?>($"{EndpointConstants.ChessCom.GET_PLAYER_MONTHLY_ARCHIVES(playerName,year,month)}");
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

        #region Club Endpoints

        /// <summary>
        /// Get additional details about a club.
        /// </summary>
        /// <param name="clubName">The name of the club</param>
        /// <returns>An <c>ApiResponse<GetClubDetailsResponse></c> object</returns>
        /// <remarks>
        /// All club-based URLs use the club's "URL ID" to specify which club you want data for.
        /// https://api.chess.com/pub/club/{url-ID}
        ///The url-ID is the same as found in the URL for the club's web page on www.chess.com. For example, the url-ID of the Chess.com Developer's Club is chess-com-developer-community
        /// </remarks>
        public async Task<ApiResponse<GetClubDetailsResponse?>> GetClubDetails(string clubName)
        {
            ArgumentException.ThrowIfNullOrEmpty(clubName, nameof(clubName));
            return await BuildApiResponse<GetClubDetailsResponse?>($"{EndpointConstants.ChessCom.GET_CLUB_DETAILS(clubName)}");
        }

        /// <summary>
        /// List of club members (usernames and joined date timestamp), grouped by club-activity frequency. The club-activity is one of this actions:
        /// - Viewing the club homepage
        /// - Viewing the clubs news index or a specific news article(but not the notification message received that the news was published)
        /// - Changing their club settings, including modifying their membership; for admins, this includes inviting or authorizing new members
        /// - Viewing the club's tournament, team match, or votechess lists
        /// - Viewing club membership lists or running a related search, or viewing the leaderboards for the club
        /// </summary>
        /// <param name="clubName">The name of the club</param>
        /// <returns>An <c>ApiResponse<GetClubDetailsResponse></c> object</returns>
        /// <remarks>
        /// All club-based URLs use the club's "URL ID" to specify which club you want data for.
        /// The url-ID is the same as found in the URL for the club's web page on www.chess.com. For example, the url-ID of the Chess.com Developer's Club is chess-com-developer-community
        /// </remarks>
        public async Task<ApiResponse<GetClubMembersResponse?>> GetClubMembers(string clubName)
        {
            ArgumentException.ThrowIfNullOrEmpty(clubName, nameof(clubName));
            return await BuildApiResponse<GetClubMembersResponse?>($"{EndpointConstants.ChessCom.GET_CLUB_MEMBERS(clubName)}");
        }

        #endregion

        #region Leaderboard endpoints

        /// <summary>
        /// Displays information about top 50 player for daily and live games, tactics and lessons.
        /// </summary>
        /// <returns>A <c>GetLeaderboardsResponse</c></returns>
        public async Task<ApiResponse<GetLeaderboardsResponse?>> GetLeaderboards()
        {
            return await BuildApiResponse<GetLeaderboardsResponse?>($"{EndpointConstants.ChessCom.GET_LEADERBOARDS}");
        }

        #endregion

    }

}
