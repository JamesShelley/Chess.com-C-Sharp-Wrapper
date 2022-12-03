using ChessData.Library.Core.APIs;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using System.Reflection;

namespace ChessData.Library.Tests.ApiTests.LiChessAPI
{
    [Collection("LichessApiTests")]
    public class AnalysisTests
    {
        private readonly string _oAuthToken;
        private readonly HttpClient client = new()
        {
            Timeout = TimeSpan.FromSeconds(60),
            BaseAddress = new Uri("https://lichess.org/api"),
        };
        private readonly LiChessApi lichessApi;

        public AnalysisTests()
        {
            var configuration = new ConfigurationBuilder()
            .AddUserSecrets(Assembly.GetExecutingAssembly(), true)
            .Build();

            _oAuthToken = configuration["LichessToken"];
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _oAuthToken);
            lichessApi = new LiChessApi(client);
        }

        /// <summary>
        /// Checks GetPositionCloudAnalysis correctly returns data
        /// </summary>
        [Fact]
        public async Task GetPositionCloudAnalysis_Returns_ValidData()
        {
            Thread.Sleep(3000);
            var moveAnalysis = await lichessApi.GetPositionCloudAnalysis("rnbqkbnr/ppp1pppp/8/3pP3/8/8/PPPP1PPP/RNBQKBNR b KQkq - 0 2");

            Assert.NotNull(moveAnalysis);
            Assert.True(moveAnalysis.ResponseStatusCode == System.Net.HttpStatusCode.OK);
            Assert.Equal("rnbqkbnr/ppp1pppp/8/3pP3/8/8/PPPP1PPP/RNBQKBNR b KQkq - 0 2", moveAnalysis.ResponseData?.Fen);
        }
    }
}
