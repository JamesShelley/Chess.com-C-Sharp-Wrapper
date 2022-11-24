using System.Text.Json.Serialization;

namespace ChesscomAPI.Library.DTOs.Streamers
{
    public sealed class GetStreamersResponse
    {

        public List<StreamerDto>? Streamers { get; set; }

        public class StreamerDto
        {
            [JsonPropertyName("username")]
            public string? Username { get; set; }
            [JsonPropertyName("avatar")]
            public string? Avatar { get; set; }
            [JsonPropertyName("twitch_url")]
            public string? TwitchUrl { get; set; }
            [JsonPropertyName("url")]
            public string? Url { get; set; }
            [JsonPropertyName("is_live")]
            public bool IsLive { get; set; }
            [JsonPropertyName("is_community_streamer")]
            public bool IsCommunityStreamer { get; set; }
        }
    }
}
