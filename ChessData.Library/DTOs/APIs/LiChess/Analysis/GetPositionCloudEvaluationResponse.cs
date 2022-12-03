namespace ChessData.Library.DTOs.APIs.LiChess.Analysis
{
    public sealed class GetPositionCloudEvaluationResponse
    {
        public string? Fen { get; set; }
        public int Knodes { get; set; }
        public int Depth { get; set; }
        public List<PvsDto>? Pvs { get; set; }

        public class PvsDto
        {
            public string? Moves { get; set; }
            public int Cp { get; set; }
        }
    }
}