using ChesscomAPI.Library.DTOs.Players;
using ChesscomAPI.Library.Services;

namespace ChesscomAPI.Library.Tests.ApiTests
{
    /// <summary>
    /// Tests player specific elements of our API Wrapper
    /// </summary>
    public sealed class PlayerDataTests
    {
        private readonly ChesscomApi chessApi = new(new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(60),
            BaseAddress = new Uri("https://api.chess.com")
        });

        [Fact]
        public async Task GetPlayerProfileData_Empty_Name_Throws_ArgumentException()
        {
            await Assert.ThrowsAsync<ArgumentException>(async () => await chessApi.GetPlayerProfileData(string.Empty));
        }

        [Fact]
        public async Task GetPlayerProfileData_Null_Name_Throws_ArgumentNullException()
        {
            await Assert.ThrowsAsync<ArgumentNullException>(async () => await chessApi.GetPlayerProfileData(null));
        }

        [Fact]
        public async Task GetPlayerProfileData_Good_Name_Gives_Valid_Data()
        {
            //Arrange
            var expectedPlayerResult = new GetPlayerProfileDataResponse
            {
                PlayerId = 41,
                Id = "https://api.chess.com/pub/player/erik",
                Url = "https://www.chess.com/member/erik",
                Username = "erik"
            };
            //Act
            var playerData = await chessApi.GetPlayerProfileData("erik");
            //Assert

            Assert.True(
                expectedPlayerResult.PlayerId == playerData.ResponseData.PlayerId
                && expectedPlayerResult.Id == playerData.ResponseData.Id
                && expectedPlayerResult.Url == playerData.ResponseData.Url
                && expectedPlayerResult.Username == playerData.ResponseData.Username);
        }

        [Fact]
        public async Task GetPlayerTournaments_Good_Name_Gives_Valid_Data()
        {
            //Act
            var playerData = await chessApi.GetPlayerTournaments("erik");
            //Assert

            Assert.True(playerData.ResponseData?.Finished?.Any());
        }

    }
}