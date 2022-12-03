using ChessData.Library.Core.APIs;
using ChessData.Library.DTOs.APIs.Chesscom.Puzzles;

namespace ChessData.Library.Tests.ApiTests.ChesscomAPI
{
    /// <summary>
    /// Tests specific to chess.com api puzzle endpoints
    /// </summary>
    [Collection("ChessDotComApiTests")]
    public class PuzzleTests
    {
        private readonly ChesscomApi chessApi = new(new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(60),
            BaseAddress = new Uri("https://api.chess.com")
        });

        [Fact]
        public async Task GetDailyPuzzle_Returns_Valid_Data()
        {
            Thread.Sleep(3000);
            var dailyPuzzle = await chessApi.GetDailyPuzzle();
            Assert.NotNull(dailyPuzzle);
            Assert.True(dailyPuzzle.ResponseStatusCode == System.Net.HttpStatusCode.OK);
            Assert.True(!string.IsNullOrEmpty(dailyPuzzle.ResponseData?.Title));
            Assert.IsAssignableFrom<GetDailyPuzzleResponse>(dailyPuzzle.ResponseData);
        }

        [Fact]
        public async Task GetRandomPuzzle_Returns_Valid_Data()
        {
            Thread.Sleep(3000);
            var randomPuzzle = await chessApi.GetRandomPuzzle();
            Assert.NotNull(randomPuzzle);
            Assert.True(randomPuzzle.ResponseStatusCode == System.Net.HttpStatusCode.OK);
            Assert.True(!string.IsNullOrEmpty(randomPuzzle.ResponseData?.Title));
            Assert.IsAssignableFrom<GetRandomPuzzleResponse>(randomPuzzle.ResponseData);
        }
    }
}
