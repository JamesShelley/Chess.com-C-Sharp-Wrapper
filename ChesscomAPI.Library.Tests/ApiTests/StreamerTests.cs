using ChesscomAPI.Library.Services;

namespace ChesscomAPI.Library.Tests.ApiTests
{
    public sealed class StreamerTests
    {
        private readonly ChesscomApi chessApi = new(new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(60),
            BaseAddress = new Uri("https://api.chess.com")
        });

        [Fact]
        public async Task GetStreamers_Returns_Valid_Results()
        {
            var streamers = await chessApi.GetStreamers();
            Assert.True(streamers.ResponseData?.Streamers?.Any());
        }
    }
}
