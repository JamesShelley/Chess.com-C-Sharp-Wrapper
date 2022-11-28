using ChessData.Library.Core.APIs;

namespace ChessData.Library.Tests.ApiTests.ChesscomAPI
{
    /// <summary>
    /// Tests specific to chess.com api club endpoints
    /// </summary>
    public class ClubTests
    {
        private readonly ChesscomApi chessApi = new(new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(60),
            BaseAddress = new Uri("https://api.chess.com")
        });
         
        /// <summary>
        /// Checks the GetClubDetails correctly returns data from https://api.chess.com/pub/club/chess-com-developer-community
        /// </summary>
        [Fact]
        public async Task GetClubDetails_Returns_Valid_Data()
        {
            Thread.Sleep(1000);
            var clubData = await chessApi.GetClubDetails("chess-com-developer-community");

            Assert.NotNull(clubData);
            Assert.True(clubData.ResponseStatusCode == System.Net.HttpStatusCode.OK);
            Assert.True(clubData.ResponseData?.Id == "https://api.chess.com/pub/club/chess-com-developer-community");
        }

        /// <summary>
        /// Checks the GetClubMembers correctly returns data from https://api.chess.com/pub/club/chess-com-developer-community/members
        /// </summary>
        [Fact]
        public async Task GetClubMembers_Returns_Valid_Data()
        {
            Thread.Sleep(1000);
            var clubMembers = await chessApi.GetClubMembers("chess-com-developer-community");
            Assert.NotNull(clubMembers);
            Assert.True(clubMembers.ResponseStatusCode == System.Net.HttpStatusCode.OK);
        }
    }
}
