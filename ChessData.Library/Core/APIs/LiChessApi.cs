using ChessData.Library.Constants;
using ChessData.Library.DTOs.APIs.LiChess.Account;
using ChessData.Library.Interfaces;
using ChessData.Library.Models;
using System.Text.Json;

namespace ChessData.Library.Core.APIs
{
    internal sealed class LiChessApi : ApiResponseBuilder, ILiChessApi
    {
        // LiChess API uses CamelCase
        static JsonSerializerOptions options = new JsonSerializerOptions
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
    }
}
