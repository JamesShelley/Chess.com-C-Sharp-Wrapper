
# ChessData - C# Client library for interacting with Chess Data across the web

Status: Active Development, expect constant breaking changes until a stable release!

## Current Plan: 
- Full Wrapper around the Chess.com API
- Full Wrapper around the LiChess API
- Historical Game Analysis

## Usage/Examples

### Register the client 
Adds a IHttpClientFactory to your service collection and configures a binding to our IChesscomApi interface
```
builder.Services.AddChessDataServices();
```
### Example DI use
```
public class TestController 
{
    private readonly IChesscomApi _chessApiClient;

    public TestController(IChesscomApi chessApiClient)
    {
        _chessApiClient = chessApiClient;
    }

    public IActionResult SomeMethod()
    {
        var playerData = _chessApiClient.GetPlayerProfileData("hikaru");
        return Ok(playerData);
    }

}
```

