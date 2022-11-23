using ChesscomAPI.Library.DTOs.Players;
using ChesscomAPI.Library.Models;

namespace ChesscomAPI.Library.Interfaces
{
    public interface IChesscomApi
    {
        #region Players
        Task<ApiResponse<GetPlayerProfileDataResponse?>> GetPlayerProfileData(string playerName);
        Task<ApiResponse<GetTitledPlayersResponse?>> GetTitledPlayers(string title);
        Task<ApiResponse<GetPlayerStatsDataResponse?>> GetPlayerStatsData(string playerName);
        #endregion

        #region Clubs

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

        #endregion

        #region Leaderboards

        #endregion
    }
}
