using System.Text.Json.Serialization;

namespace ChessData.Library.DTOs.APIs.Chesscom.Players
{
    public sealed class GetTitledPlayersResponse
    {
        [JsonPropertyName("players")]
        public List<string>? TitledPlayers { get; set; }
    }
}
