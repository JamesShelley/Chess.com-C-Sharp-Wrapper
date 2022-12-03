using ChessData.Library.Constants;
using ChessData.Library.DTOs.APIs.LiChess.Account;
using ChessData.Library.DTOs.APIs.LiChess.Analysis;
using ChessData.Library.Interfaces;
using ChessData.Library.Models;
using System.Text.Json;

namespace ChessData.Library.Core.APIs
{
    internal sealed class LiChessApi : ApiResponseBuilder, ILiChessApi
    {
        // LiChess API uses CamelCase
        private static readonly JsonSerializerOptions options = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        public LiChessApi(HttpClient httpClient) : base(httpClient, options) { }

        #region ACCOUNT endpoints

        public async Task<ApiResponse<GetMyLiChessProfile?>> GetMyProfile()
        {
            return await BuildApiResponse<GetMyLiChessProfile?>($"{EndpointConstants.LiChess.GET_MY_PROFILE}");
        }

        public async Task<ApiResponse<GetMyEmailAddressResponse?>> GetMyEmailAddress()
        {
            return await BuildApiResponse<GetMyEmailAddressResponse?>($"{EndpointConstants.LiChess.GET_MY_EMAIL_ADDRESS}");
        }

        public async Task<ApiResponse<GetMyPreferencesResponse?>> GetMyPreferences()
        {
            return await BuildApiResponse<GetMyPreferencesResponse?>($"{EndpointConstants.LiChess.GET_MY_PREFERENCES}");
        }

        #endregion

        #region ANALYSIS ENDPOINTS

         public async Task<ApiResponse<GetPositionCloudEvaluationResponse?>> GetPositionCloudAnalysis(string fen, int multiPv = 1, string variant = "standard")
        {
            ArgumentException.ThrowIfNullOrEmpty(fen);
            return await BuildApiResponse<GetPositionCloudEvaluationResponse?>($"{EndpointConstants.LiChess.GET_POSITION_ANALYSIS(fen, multiPv, variant)}");
        }

        #endregion
    }
}
