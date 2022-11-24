using System.Net.Http;
using System.Net;
using System.Text.Json;
using System.Net.Http.Json;
using ChessData.Library.Models;
using ChessData.Library.Core.Json;

namespace ChessData.Library.Core.APIs
{
    internal class ApiResponseBuilder
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _serializerOptions;

        internal ApiResponseBuilder(HttpClient client, JsonSerializerOptions serializerOptions)
        {
            _httpClient = client;
            _serializerOptions = serializerOptions;
        }

        /// <summary>
        /// Builds our Api response
        /// </summary>
        /// <typeparam name="T">The type we want to try too deserialze our json too</typeparam>
        /// <param name="endpoint">The chess.com api endpoint we are targetting</param>
        /// <returns>An <c>ApiResponse<typeparamref name="T"/></c>object</returns>
        protected async Task<ApiResponse<T?>> BuildApiResponse<T>(string endpoint)
        {
            var response = new ApiResponse<T?>();
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = SnakeCaseNamingPolicy.Instance
            };

            try
            {
                var apiResponse = await _httpClient.GetAsync(endpoint);
                apiResponse.EnsureSuccessStatusCode();
                response.ResponseStatusCode = apiResponse.StatusCode;
                response.ResponseMessage = apiResponse.ReasonPhrase;
                response.ResponseData = await apiResponse.Content.ReadFromJsonAsync<T>(_serializerOptions);
                response.RawResponse = await apiResponse.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                response.ResponseStatusCode = ex.StatusCode;
                response.ResponseMessage = $"Error: {ex.InnerException?.Message}";
            }
            catch (Exception ex)
            {
                response.ResponseStatusCode = HttpStatusCode.InternalServerError;
                response.ResponseMessage = $"Error {ex.Message}";
            }

            return response;
        }
    }
}
