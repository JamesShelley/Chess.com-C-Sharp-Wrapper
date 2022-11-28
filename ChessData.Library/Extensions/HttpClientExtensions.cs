using ChessData.Library.Core.APIs;
using ChessData.Library.Core.Options;
using ChessData.Library.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Headers;
namespace ChessData.Library.Extensions
{
    public static class HttpClientExtensions
    {
        public static void AddChessDataServices(this IServiceCollection services, ChessDataRegistration? options = null)
        {
            services.AddHttpClient<IChesscomApi, ChesscomApi>(client =>
            {
                client.Timeout = options != null ? options.ClientTimeout != 0 ? TimeSpan.FromSeconds(options.ClientTimeout) : TimeSpan.FromSeconds(60) : TimeSpan.FromSeconds(60);
                client.BaseAddress = new Uri("https://api.chess.com");
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("ChessData", "v0.1"));
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("(+https://github.com/JamesShelley/ChessData)"));
                if (options != null && !string.IsNullOrEmpty(options.UserAgent))
                {
                    client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(options.UserAgent));
                }
            });

            if (!string.IsNullOrEmpty(options?.LichessPersonalAccessToken))
            {
                services.AddHttpClient<ILiChessApi, LiChessApi>(client =>
                {
                    client.Timeout = options.ClientTimeout != 0 ? TimeSpan.FromSeconds(options.ClientTimeout) : TimeSpan.FromSeconds(60);
                    client.BaseAddress = new Uri("https://lichess.org/api");
                    client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("ChessData", "v0.1"));
                    client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("(+https://github.com/JamesShelley/ChessData)"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", options.LichessPersonalAccessToken);
                    if (options != null && !string.IsNullOrEmpty(options.UserAgent))
                    {
                        client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(options.UserAgent));
                    }
                });
            }
        }
    }
}
