using System.Text.Json.Serialization;

namespace ChessData.Library.DTOs.APIs.Chesscom.Players
{
    public sealed class GetPlayerClubsResponse
    {
        public List<PlayerClubsDto>? Clubs { get; set; }

        public class PlayerClubsDto
        {
            [JsonPropertyName("@id")]
            public string? Id { get; set; }
            public string? Name { get; set; }
            public long LastActivity { get; set; }
            public string? Icon { get; set; }
            public string? Url { get; set; }
            public long Joined { get; set; }
        }
    }
}
