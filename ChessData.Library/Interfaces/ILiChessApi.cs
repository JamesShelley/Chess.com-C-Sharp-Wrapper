using ChessData.Library.DTOs.APIs.LiChess.Profile;
using ChessData.Library.Models;

namespace ChessData.Library.Interfaces
{
    public interface ILiChessApi
    {
        #region Profile
        Task<ApiResponse<GetLiChessProfile?>> GetPlayerProfile();
        #endregion
    }
}
