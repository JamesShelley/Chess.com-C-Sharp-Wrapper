using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessData.Library.DTOs.APIs.LiChess.Profile
{
    public sealed class GetMyLiChessProfile
    {
        public string? Id { get; set; }
        public string? Username { get; set; }
        public PerfsDto? Perfs { get; set; }
        public long? CreatedAt { get; set; }
        public bool? Disabled { get; set; }
        public bool? TosViolation { get; set; }
        public ProfileDto? Profile { get; set; }
        public long? SeenAt { get; set; }
        public bool? Patron { get; set; }
        public bool? Verified { get; set; }
        public PlayTimeDto? PlayTime { get; set; }
        public string? Title { get; set; }
        public string? Url { get; set; }
        public string? Playing { get; set; }
        public int? CompletionRate { get; set; }
        public CountDto? Count { get; set; }
        public bool? Streaming { get; set; }
        public bool? Followable { get; set; }
        public bool? Following { get; set; }
        public bool? Blocking { get; set; }
        public bool? FollowsYou { get; set; }

        public class Atomic
        {
            public int? Games { get; set; }
            public int? Rating { get; set; }
            public int? Rd { get; set; }
            public int? Prog { get; set; }
            public bool? Prov { get; set; }
        }

        public class Blitz
        {
            public int? Games { get; set; }
            public int? Rating { get; set; }
            public int? Rd { get; set; }
            public int? Prog { get; set; }
            public bool? Prov { get; set; }
        }

        public class Bullet
        {
            public int? Games { get; set; }
            public int? Rating { get; set; }
            public int? Rd { get; set; }
            public int? Prog { get; set; }
            public bool? Prov { get; set; }
        }

        public class Chess960
        {
            public int? Games { get; set; }
            public int? Rating { get; set; }
            public int? Rd { get; set; }
            public int? Prog { get; set; }
            public bool? Prov { get; set; }
        }

        public class Classical
        {
            public int? Games { get; set; }
            public int? Rating { get; set; }
            public int? Rd { get; set; }
            public int? Prog { get; set; }
            public bool? Prov { get; set; }
        }

        public class Correspondence
        {
            public int? Games { get; set; }
            public int? Rating { get; set; }
            public int? Rd { get; set; }
            public int? Prog { get; set; }
            public bool? Prov { get; set; }
        }

        public class CountDto
        {
            public int? All { get; set; }
            public int? Rated { get; set; }
            public int? Ai { get; set; }
            public int? Draw { get; set; }
            public int? DrawH { get; set; }
            public int? Loss { get; set; }
            public int? LossH { get; set; }
            public int? Win { get; set; }
            public int? WinH { get; set; }
            public int? Bookmark { get; set; }
            public int? Playing { get; set; }
            public int? Import { get; set; }
            public int? Me { get; set; }
        }

        public class Horde
        {
            public int? Games { get; set; }
            public int? Rating { get; set; }
            public int? Rd { get; set; }
            public int? Prog { get; set; }
            public bool? Prov { get; set; }
        }

        public class KingOfTheHill
        {
            public int? Games { get; set; }
            public int? Rating { get; set; }
            public int? Rd { get; set; }
            public int? Prog { get; set; }
            public bool? Prov { get; set; }
        }

        public class PerfsDto
        {
            public Chess960? Chess960 { get; set; }
            public Atomic? Atomic { get; set; }
            public RacingKings? RacingKings { get; set; }
            public UltraBullet? UltraBullet { get; set; }
            public Blitz? Blitz { get; set; }
            public KingOfTheHill? KingOfTheHill { get; set; }
            public Bullet? Bullet { get; set; }
            public Correspondence? Correspondence { get; set; }
            public Horde? Horde { get; set; }
            public Puzzle? Puzzle { get; set; }
            public Classical? Classical { get; set; }
            public Rapid? Rapid { get; set; }
            public Storm? Storm { get; set; }
        }

        public class PlayTimeDto
        {
            public int? Total { get; set; }
            public int? Tv { get; set; }
        }

        public class ProfileDto
        {
            public string? Country { get; set; }
            public string? Location { get; set; }
            public string? Bio { get; set; }
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public int? FideRating { get; set; }
            public int? UscfRating { get; set; }
            public int? EcfRating { get; set; }
            public string? Links { get; set; }
        }

        public class Puzzle
        {
            public int? Games { get; set; }
            public int? Rating { get; set; }
            public int? Rd { get; set; }
            public int? Prog { get; set; }
            public bool? Prov { get; set; }
        }

        public class RacingKings
        {
            public int? Games { get; set; }
            public int? Rating { get; set; }
            public int? Rd { get; set; }
            public int? Prog { get; set; }
            public bool? Prov { get; set; }
        }

        public class Rapid
        {
            public int? Games { get; set; }
            public int? Rating { get; set; }
            public int? Rd { get; set; }
            public int? Prog { get; set; }
            public bool? Prov { get; set; }
        }

        public class Storm
        {
            public int? Runs { get; set; }
            public int? Score { get; set; }
        }

        public class UltraBullet
        {
            public int? Games { get; set; }
            public int? Rating { get; set; }
            public int? Rd { get; set; }
            public int? Prog { get; set; }
            public bool? Prov { get; set; }
        }

    }
}
