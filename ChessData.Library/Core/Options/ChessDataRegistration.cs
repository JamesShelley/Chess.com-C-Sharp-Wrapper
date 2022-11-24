using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessData.Library.Core.Options
{
    public class ChessDataRegistration
    {
        public string? UserAgent { get; set; }
        public int ClientTimeout { get; set; }
        public string? LichessPersonalAccessToken { get; set; }
    }
}
