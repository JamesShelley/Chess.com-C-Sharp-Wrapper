using ChessData.Library.Core.APIs;
using ChessData.Library.Core.Json;
using ChessData.Library.DTOs.APIs.Chesscom.Players;
using ChessData.Library.Interfaces;
using ChessData.Library.Models;
using System.Text.Json;

namespace ChessData.Library.Tests.ApiTests
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

            Assert.True(playerData.ResponseStatusCode == System.Net.HttpStatusCode.OK);
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