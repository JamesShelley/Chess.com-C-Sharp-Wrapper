using ChesscomAPI.Library.Interfaces;
using ChesscomAPI.Library.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ChesscomAPI.Library.Extensions
{
    public static class HttpClientExtensions
    {
        public static void AddChesscomClient(this IServiceCollection services)
        {
            services.AddHttpClient<IChesscomApi, ChesscomApi>(client =>
            {
                client.Timeout = TimeSpan.FromSeconds(60);
                client.BaseAddress = new Uri("https://api.chess.com");
                client.DefaultRequestHeaders.Add("Library", "C# Chess.com API Client Wrapper");
            });
        }
    }
}
