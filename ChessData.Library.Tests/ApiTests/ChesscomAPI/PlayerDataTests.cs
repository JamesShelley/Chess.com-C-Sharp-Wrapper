using ChessData.Library.Constants;
using ChessData.Library.Core.APIs;
using ChessData.Library.DTOs.APIs.Chesscom.Players;

namespace ChessData.Library.Tests.ApiTests.ChesscomAPI
{
    /// <summary>
    /// Tests player specific elements of our API Wrapper
    /// </summary>
    public sealed class PlayerDataTests
    {
        private readonly ChesscomApi chesscomApi = new(new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(60),
            BaseAddress = new Uri("https://api.chess.com")
        });

        [Fact]
        public async Task GetPlayerProfileData_Empty_Name_Throws_ArgumentException()
        {
            await Assert.ThrowsAsync<ArgumentException>(async () => await chesscomApi.GetPlayerProfileData(string.Empty));
        }

        [Fact]
        public async Task GetPlayerProfileData_Good_Name_Gives_Valid_Data()
        {
            Thread.Sleep(1000);

            //Arrange
            var expectedPlayerResult = new GetPlayerProfileDataResponse
            {
                PlayerId = 41,
                Id = "https://api.chess.com/pub/player/erik",
                Url = "https://www.chess.com/member/erik",
                Username = "erik"
            };
            //Act
            var playerData = await chesscomApi.GetPlayerProfileData("erik");

            //Assert
            Assert.NotNull(playerData);
            Assert.Equal(playerData.ResponseStatusCode, System.Net.HttpStatusCode.OK);
            Assert.Equal(expectedPlayerResult.Username, playerData.ResponseData?.Username);
        }

        [Fact]
        public async Task GetPlayerTournaments_Good_Name_Gives_Valid_Data()
        {
            Thread.Sleep(1000);

            //Act
            var playerData = await chesscomApi.GetPlayerTournaments("erik");

            //Assert
            Assert.NotNull(playerData);
            Assert.True(playerData.ResponseData?.Finished?.Any());
            Assert.Equal(playerData.ResponseStatusCode, System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task GetTitledPlayers_Returns_Valid_Data()
        {
            Thread.Sleep(1000);

            //Act
            var titledPlayers = await chesscomApi.GetTitledPlayers(ChessTitles.GRANDMASTER);

            //Assert
            Assert.NotNull(titledPlayers);
            Assert.True(titledPlayers.ResponseData?.TitledPlayers?.Any());
            Assert.Equal(titledPlayers.ResponseStatusCode, System.Net.HttpStatusCode.OK);   
        }

        [Fact]
        public async Task GetPlayerDailyGames_Returns_Valid_Data()
        {
            Thread.Sleep(1000);

            // Act
            var playerGames = await chesscomApi.GetPlayerDailyGames("erik");
            
            // Assert
            Assert.NotNull(playerGames);
            Assert.Equal(playerGames.ResponseStatusCode, System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task GetPlayerTournaments_Returns_Valid_Data()
        {
            Thread.Sleep(1000);

            // Act
            var playerTournaments = await chesscomApi.GetPlayerTournaments("erik");

            // Assert
            Assert.NotNull(playerTournaments);
            Assert.Equal(playerTournaments.ResponseStatusCode, System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task GetPlayerStatsData_Returns_Valid_Data()
        {
            Thread.Sleep(1000);

            // Act
            var playerStats = await chesscomApi.GetPlayerStatsData("erik");

            // Assert
            Assert.NotNull(playerStats);
            Assert.Equal(playerStats.ResponseStatusCode, System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task GetPlayerMonthlyArchives_Returns_Valid_Data()
        {
            Thread.Sleep(1000);

            // Act
            var playerGames = await chesscomApi.GetPlayerMonthlyGameArchives("erik","2009","10");

            // Assert
            Assert.NotNull(playerGames);
            Assert.NotNull(playerGames.ResponseData?.Games);
            Assert.Equal(playerGames.ResponseData?.Games?.Count, 46);
            Assert.Equal(playerGames.ResponseStatusCode, System.Net.HttpStatusCode.OK);
        }

        [Fact]
        public async Task GetTitledPlayers_Empty_Title_Returns_Error()
        {
            Thread.Sleep(1000);
            await Assert.ThrowsAsync<ArgumentException>(async () => await chesscomApi.GetTitledPlayers(string.Empty));
        }

        [Fact]
        public async Task GetPlayerClubs_Returns_Valid_Data()
        {
            Thread.Sleep(1000);
            var playerClubs = await chesscomApi.GetPlayerClubs("erik");

            Assert.Equal(playerClubs.ResponseStatusCode, System.Net.HttpStatusCode.OK);
            Assert.NotNull(playerClubs);
            Assert.NotNull(playerClubs.ResponseData?.Clubs);
            Assert.True(playerClubs.ResponseData?.Clubs?.Any());
        }
    }
}