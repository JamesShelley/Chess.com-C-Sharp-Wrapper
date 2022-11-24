using ChesscomAPI.Library.Utilities;
using System.Text.Json;

namespace ChesscomAPI.Library.Core
{
    internal sealed class SnakeCaseNamingPolicy : JsonNamingPolicy
    {
        public static SnakeCaseNamingPolicy Instance { get; } = new SnakeCaseNamingPolicy();

        public override string ConvertName(string name)
        {
            return name.ToSnakeCase();
        }
    }
}
