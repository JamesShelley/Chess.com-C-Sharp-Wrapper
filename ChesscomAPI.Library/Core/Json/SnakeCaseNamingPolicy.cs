using ChesscomAPI.Library.Extensions;
using System.Text.Json;

namespace ChesscomAPI.Library.Core.Json
{
    /// <summary>
    /// System.Text.Json doesn't have support for snake case, so create a new naming policy for this.
    /// </summary>
    internal sealed class SnakeCaseNamingPolicy : JsonNamingPolicy
    {
        internal static SnakeCaseNamingPolicy Instance { get; } = new SnakeCaseNamingPolicy();

        public override string ConvertName(string name)
        {
            return name.ToSnakeCase();
        }
    }
}
