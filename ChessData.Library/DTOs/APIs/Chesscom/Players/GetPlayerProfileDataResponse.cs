using System.Text.Json.Serialization;

namespace ChessData.Library.DTOs.APIs.Chesscom.Players
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
        public string? Url { get; set; }

        /// <summary>
        /// The username of this player
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// The non-changing Chess.com ID of this player
        /// </summary>
        public long PlayerId { get; set; }

        public string? Title { get; set; }
        public string? Status { get; set; }

        public string? Name { get; set; }
        public string? Avatar { get; set; }

        public string? Location { get; set; }

        public string? Country { get; set; }

        public long Joined { get; set; }

        public long LastOnline { get; set; }

        public long Followers { get; set; }

        public bool IsStreamer { get; set; }

        public string? TwitchUrl { get; set; }

        public int Fide { get; set; }

        public bool Verified { get; set; }

    }
}
