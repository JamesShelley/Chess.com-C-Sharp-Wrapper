using System.Net;

namespace ChessData.Library.Models
{
    public sealed class ApiResponse<T>
    {
        //The data we get back from our the chess.com api endpoint
        public T? ResponseData { get; set; }

        //The response code we get back from the chess.com api endpoint
        public HttpStatusCode? ResponseStatusCode { get; set; }

        //The response message we get back from the chess.com api endpoint
        public string? ResponseMessage { get; set; }

        //The raw json response we actually got back from the API
        public string? RawResponse { get; set; }
        
        //The endpoint we requested
        public string? RequestedUrl { get; set; }
    }
}
