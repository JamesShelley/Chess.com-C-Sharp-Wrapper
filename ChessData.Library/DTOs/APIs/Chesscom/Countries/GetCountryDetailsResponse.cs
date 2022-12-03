using System.Text.Json.Serialization;

namespace ChessData.Library.DTOs.APIs.Chesscom.Countries
{
    public class GetCountryDetailsResponse
    {
        // the location of this profile (always self-referencing)
        [JsonPropertyName("@id")]
        public string? Id { get; set; }
        // the human-readable name of this country
        public string? Name { get; set; }
        // the ISO-3166-1 2-character code
        public string? Code { get; set; }
    }
}