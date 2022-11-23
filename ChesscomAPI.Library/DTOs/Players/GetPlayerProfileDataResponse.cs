using System.Text.Json.Serialization;

namespace ChesscomAPI.Library.DTOs.Players
{
    public sealed class GetPlayerProfileDataResponse
    {
        /// <summary>
        /// The location of this profile (always self-referencing)
        /// </summary>
        [JsonPropertyName("@id")]
        public string? Id { get; set; }

        /// <summary>
        /// The chess.com user's profile page (the username is displayed with the original letter case)
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The username of this player
        /// </summary>
        [JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// The non-changing Chess.com ID of this player
        /// </summary>
        [JsonPropertyName("player_id")]
        public long PlayerId { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        [JsonPropertyName("location")]
        public string? Location { get; set; }

        [JsonPropertyName("country")]
        public string? Country { get; set; }

        [JsonPropertyName("joined")]
        public long Joined { get; set; }

        [JsonPropertyName("last_online")]
        public long LastOnline { get; set; }

        [JsonPropertyName("followers")]
        public long Followers { get; set; }

        [JsonPropertyName("is_streamer")]
        public bool IsStreamer { get; set; }

        [JsonPropertyName("twitch_url")]
        public string? TwitchUrl { get; set; }

        [JsonPropertyName("fide")]
        public int Fide { get; set; }

        [JsonPropertyName("verified")]
        public bool Verified { get; set; }

    }
}
