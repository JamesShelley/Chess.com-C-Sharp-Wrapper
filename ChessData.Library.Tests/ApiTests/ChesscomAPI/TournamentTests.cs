namespace ChessData.Library.Tests.ApiTests.ChesscomAPI;
using ChessData.Library.Core.APIs;

    /// <summary>
    /// Tests specific to chess.com api club endpoints
    /// </summary>
    [Collection("ChessDotComApiTests")]
    public sealed class TournamentTests
    {
        private readonly ChesscomApi chessApi = new(new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(60),
            BaseAddress = new Uri("https://api.chess.com")
        });

        /// <summary>
        /// Checks GetTournament correctly returns data from https://api.chess.com/pub/tournament/{tournamentName}
        /// </summary>
        [Fact]
        public async Task GetTournament_Returns_Valid_Results()
        {
            Thread.Sleep(3000);
            var tournament = await chessApi.GetTournament("-33rd-chesscom-quick-knockouts-1401-1600");
            Assert.NotNull(tournament);
            Assert.True(tournament.ResponseStatusCode == System.Net.HttpStatusCode.OK);
            Assert.Equal("33rd Chess.com Quick Knockouts (1401-1600)",tournament.ResponseData?.Name);
            Assert.Equal("https://www.chess.com/tournament/-33rd-chesscom-quick-knockouts-1401-1600",tournament.ResponseData?.Url);
            Assert.Equal(399,tournament.ResponseData?.Players?.Count);
            Assert.Equal(4, tournament.ResponseData?.Rounds?.Count);
        }

        /// <summary>
        /// Checks GetTournament correctly returns data from https://api.chess.com/pub/tournament/{tournamentName}/{round}
        /// </summary>
        [Fact]
        public async Task GetTournamentRound_Returns_Valid_Results()
        {
            Thread.Sleep(3000);
            var tournament = await chessApi.GetTournamentRound("-33rd-chesscom-quick-knockouts-1401-1600", 1);
            Assert.NotNull(tournament);
            Assert.True(tournament.ResponseStatusCode == System.Net.HttpStatusCode.OK);
            Assert.Equal(67, tournament.ResponseData?.Groups?.Count);
            Assert.Equal(399,tournament.ResponseData?.Players?.Count);
        }

        /// <summary>
        /// Checks GetTournament correctly returns data from https://api.chess.com/pub/tournament/{tournamentName}/{round}/{group}
        /// </summary>
        [Fact]
        public async Task GetTournamentRoundGroup_Returns_Valid_Results()
        {
            Thread.Sleep(3000);
            var tournament = await chessApi.GetTournamentRoundGroup("-33rd-chesscom-quick-knockouts-1401-1600",1,1);
            Assert.NotNull(tournament);
            Assert.True(tournament.ResponseStatusCode == System.Net.HttpStatusCode.OK);
            Assert.Equal(20, tournament.ResponseData?.Games?.Count);
            Assert.Equal(5,tournament.ResponseData?.Players?.Count);
        }
    }
