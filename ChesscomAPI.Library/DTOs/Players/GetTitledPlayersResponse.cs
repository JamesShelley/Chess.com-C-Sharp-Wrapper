using System.Text.Json.Serialization;

namespace ChesscomAPI.Library.DTOs.Players
{
    public sealed class GetTitledPlayersResponse
    {
        [JsonPropertyName("players")]
        public List<string>? TitledPlayers { get; set; }
    }
}
