namespace ChessData.Library.DTOs.APIs.Chesscom.Clubs
{
    public sealed class GetClubMembersResponse
    {
        public List<JoinedClubDto>? Weekly { get; set; }
        public List<JoinedClubDto>? Monthly { get; set; }
        public List<JoinedClubDto>? AllTime { get; set; }

        public class JoinedClubDto
        {
            public string? Username { get; set; }
            public long Joined { get; set; }
        }
    }
}
