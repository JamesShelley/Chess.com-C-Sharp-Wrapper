namespace ChessData.Library.Tests.ApiTests.ChesscomAPI;
using ChessData.Library.Core.APIs;

    /// <summary>
    /// Tests specific to chess.com api tournament endpoints
    /// </summary>
    [Collection("ChessDotComApiTests")]
    public sealed class CountryTests
    {
        private readonly ChesscomApi chessApi = new(new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(60),
            BaseAddress = new Uri("https://api.chess.com")
        });

        /// <summary>
        /// Checks GetCountry correctly returns data from https://api.chess.com/pub/country/{countryIsoCode}
        /// </summary>
        [Fact]
        public async Task GetCountry_Returns_Valid_Results()
        {
            Thread.Sleep(3000);
            var countryDetails = await chessApi.GetCountryDetailsResponse("XE");
            Assert.NotNull(countryDetails);
            Assert.True(countryDetails.ResponseStatusCode == System.Net.HttpStatusCode.OK);
            Assert.Equal("https://api.chess.com/pub/country/XE", countryDetails.ResponseData?.Id);
            Assert.Equal("XE", countryDetails.ResponseData?.Code);
            Assert.Equal("England", countryDetails.ResponseData?.Name);
        }
       
    }