using ChessData.Library.DTOs.APIs.LiChess.Account;
using ChessData.Library.DTOs.APIs.LiChess.Analysis;
using ChessData.Library.Models;

namespace ChessData.Library.Interfaces
{
    public interface ILiChessApi
    {
        #region ACCOUNT ENDPOINTS
        Task<ApiResponse<GetMyLiChessProfile?>> GetMyProfile();
        Task<ApiResponse<GetMyEmailAddressResponse?>> GetMyEmailAddress();
        Task<ApiResponse<GetMyPreferencesResponse?>> GetMyPreferences();
        #endregion

        #region ANALYSIS ENDPOINTS
        Task<ApiResponse<GetPositionCloudEvaluationResponse?>> GetPositionCloudAnalysis(string fen, int multiPv, string variant);
        #endregion
    }
}
