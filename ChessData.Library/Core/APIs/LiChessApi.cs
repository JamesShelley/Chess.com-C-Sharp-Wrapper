using ChessData.Library.Constants;
using ChessData.Library.DTOs.APIs.LiChess.Profile;
using ChessData.Library.Interfaces;
using ChessData.Library.Models;

namespace ChessData.Library.Core.APIs
{
    internal sealed class LiChessApi : ApiResponseBuilder, ILiChessApi
    {
        public LiChessApi(HttpClient httpClient) : base(httpClient) { }

        public async Task<ApiResponse<GetLiChessProfile?>> GetPlayerProfile()
        {
            return await BuildApiResponse<GetLiChessProfile?>($"{EndpointConstants.LiChess.ACCOUNT}");
        }
    }
}
