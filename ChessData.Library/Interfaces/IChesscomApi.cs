using ChessData.Library.DTOs.APIs.Chesscom.Clubs;
using ChessData.Library.DTOs.APIs.Chesscom.Players;
using ChessData.Library.DTOs.APIs.Chesscom.Streamers;
using ChessData.Library.Models;

namespace ChessData.Library.Interfaces
{
    public interface IChesscomApi
    {
        #region Players
        Task<ApiResponse<GetPlayerProfileDataResponse?>> GetPlayerProfileData(string playerName);
        Task<ApiResponse<GetTitledPlayersResponse?>> GetTitledPlayers(string title);
        Task<ApiResponse<GetPlayerStatsDataResponse?>> GetPlayerStatsData(string playerName);
        Task<ApiResponse<GetPlayerTournamentsResponse?>> GetPlayerTournaments(string playerName);
        Task<ApiResponse<GetPlayerDailyGamesResponse?>> GetPlayerDailyGames(string playerName);

        #endregion

        #region Clubs
        Task<ApiResponse<GetClubDetailsResponse?>> GetClubDetails(string clubName);

        #endregion

        #region Tournaments

        #endregion

        #region Team matches

        #endregion

        #region Countries

        #endregion

        #region Daily puzzles

        #endregion

        #region Streamers

        Task<ApiResponse<GetStreamersResponse?>> GetStreamers();

        #endregion

        #region Leaderboards

        #endregion
    }
}
