using ChessData.Library.Core.APIs;
using ChessData.Library.Interfaces;

namespace ChessData.Library.Tests.ApiTests
{
    /// <summary>
    /// Tests specific to chess.com api club endpoints
    /// </summary>
    public sealed class StreamerTests
    {
        private readonly ChesscomApi chessApi = new(new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(60),
            BaseAddress = new Uri("https://api.chess.com")
        });

        /// <summary>
        /// Checks GetStreamers correctly returns data from https://api.chess.com/pub/streamers
        /// </summary>
        [Fact]
        public async Task GetStreamers_Returns_Valid_Results()
        {
            Thread.Sleep(1000);
            var streamers = await chessApi.GetStreamers();
            Assert.NotNull(streamers);
            Assert.True(streamers.ResponseStatusCode == System.Net.HttpStatusCode.OK);
            Assert.True(streamers.ResponseData?.Streamers?.Any());
        }
    }
}
