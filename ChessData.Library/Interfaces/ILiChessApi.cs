using ChessData.Library.DTOs.APIs.LiChess.Profile;
using ChessData.Library.Models;

namespace ChessData.Library.Interfaces
{
    public interface ILiChessApi
    {
        #region ACCOUNT ENDPOINTS
        Task<ApiResponse<GetMyLiChessProfile?>> GetMyProfile();
        Task<ApiResponse<GetMyEmailAddressResponse?>> GetMyEmailAddress();
        #endregion
    }
}
