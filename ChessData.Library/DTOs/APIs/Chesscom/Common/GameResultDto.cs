using System.Text.Json.Serialization;

namespace ChessData.Library.DTOs.APIs.Chesscom.Common
{
    public class GameResultDto
    {
        public int Rating { get; set; }
        public string? Result { get; set; }
        [JsonPropertyName("@id")]
        public string? Id { get; set; }
        public string? Username { get; set; }
        public string? Uuid { get; set; }
    }
}
