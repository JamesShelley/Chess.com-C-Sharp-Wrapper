using ChessData.Library.Core.APIs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessData.Library.Tests.ApiTests.ChesscomAPI
{
    /// <summary>
    /// Tests specific to the chess.com leaderboards endpoints
    /// </summary>
    [Collection("ChessDotComApiTests")]
    public class LeaderboardTests
    {
        private readonly ChesscomApi chessApi = new(new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(60),
            BaseAddress = new Uri("https://api.chess.com")
        });

        /// <summary>
        /// Checks the GetLeaderboardsResponse correctly returns data from https://api.chess.com/pub/leaderboards
        /// </summary>
        [Fact]
        public async Task GetLeaderboardsResponse_Returns_Valid_Data()
        {
            Thread.Sleep(3000);

            var leaderboardsData = await chessApi.GetLeaderboards();

            Assert.NotNull(leaderboardsData);
            Assert.True(leaderboardsData.ResponseStatusCode == System.Net.HttpStatusCode.OK);
            Assert.NotNull(leaderboardsData.ResponseData?.Daily);
            Assert.True(leaderboardsData.ResponseData?.Daily?.Any());

        }
    }
}
