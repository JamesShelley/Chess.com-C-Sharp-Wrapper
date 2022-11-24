
# Dot Chess - C# chess.com API Wrapper

Status: Active Development, expect constant breaking changes until a stable release!



## Usage/Examples

### Register the client 
Adds a IHttpClientFactory to your service collection and configures a binding to our IChesscomApi interface
```
builder.Services.AddChesscomClient();
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
        return Ok(playerData)'
    }

}
```

