using ChesscomAPI.Library.Interfaces;
using ChesscomAPI.Library.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using System.Net.Http.Headers;

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
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("ChessCom-CSharp-API-Wrapper", "v0.1"));
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("(+https://github.com/JamesShelley/Chess.com-C-Sharp-Wrapper)"));
            });
        }
    }
}
