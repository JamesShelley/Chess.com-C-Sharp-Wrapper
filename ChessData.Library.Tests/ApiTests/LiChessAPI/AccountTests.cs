using ChessData.Library.Core.APIs;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using System.Reflection;

namespace ChessData.Library.Tests.ApiTests.LiChessAPI
{
    [Collection("LichessApiTests")]
    public class AccountTests
    {
        private readonly string _oAuthToken;
        private readonly HttpClient client = new()
        {
            Timeout = TimeSpan.FromSeconds(60),
            BaseAddress = new Uri("https://lichess.org/api"),
        };
        private readonly LiChessApi lichessApi;

        public AccountTests()
        {
            var configuration = new ConfigurationBuilder()
            .AddUserSecrets(Assembly.GetExecutingAssembly(), true)
            .Build();

            _oAuthToken = configuration["LichessToken"];
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _oAuthToken);
            lichessApi = new LiChessApi(client);
        }

        /// <summary>
        /// Checks GetMyEmailAddress correctly returns data
        /// </summary>
        [Fact(Skip = "Until configure lichess secret as a github environment secret.")]
        public async Task GetMyEmailAddress_Returns_ValidData()
        {
            Thread.Sleep(3000);
            var lichessAcccount = await lichessApi.GetMyEmailAddress();

            Assert.NotNull(lichessAcccount);
            Assert.True(lichessAcccount.ResponseStatusCode == System.Net.HttpStatusCode.OK);
            Assert.True(!string.IsNullOrEmpty(lichessAcccount.ResponseData?.Email));
        }

        /// <summary>
        /// Checks GetMyProfile correctly returns data
        /// </summary>
        [Fact(Skip = "Until configure lichess secret as a github environment secret.")]
        public async Task GetMyProfile_Returns_ValidData()
        {
            Thread.Sleep(3000);
            var lichessAcccount = await lichessApi.GetMyProfile();

            Assert.NotNull(lichessAcccount);
            Assert.True(lichessAcccount.ResponseStatusCode == System.Net.HttpStatusCode.OK);
            Assert.True(!string.IsNullOrEmpty(lichessAcccount.ResponseData?.Username));
        }

        /// <summary>
        /// Checks GetMyPreferences correctly returns data
        /// </summary>
        [Fact(Skip = "Until configure lichess secret as a github environment secret.")]
        public async Task GetMyPreferences_Returns_ValidData()
        {
            Thread.Sleep(3000);

            var lichessPreferences = await lichessApi.GetMyPreferences();
            Assert.NotNull(lichessPreferences);
            Assert.True(lichessPreferences.ResponseStatusCode == System.Net.HttpStatusCode.OK);
        }
    }
}
