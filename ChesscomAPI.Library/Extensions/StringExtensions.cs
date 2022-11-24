namespace ChesscomAPI.Library.Extensions
{
    internal static class StringExtensions
    {
        /// <summary>
        /// Converts a string to snake_case
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        internal static string ToSnakeCase(this string str)
        {
            return string.Concat(str.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString())).ToLower();
        }
    }
}
