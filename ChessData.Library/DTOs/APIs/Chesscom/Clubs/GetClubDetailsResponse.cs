using System.Text.Json.Serialization;

namespace ChessData.Library.DTOs.APIs.Chesscom.Clubs
{
    public class GetClubDetailsResponse
    {
        [JsonPropertyName("@id")]
        public string? Id { get; set; }
        public string? Name { get; set; }
        public int ClubId { get; set; }
        public string? Country { get; set; }
        public int AverageDailyRating { get; set; }
        public int MembersCount { get; set; }
        public long Created { get; set; }
        public long LastActivity { get; set; }
        public List<string>? Admin { get; set; }
        public string? Visibility { get; set; }
        public string? JoinRequest { get; set; }
        public string? Icon { get; set; }
        public string? Description { get; set; }
        public string? Url { get; set; }

    }
}
