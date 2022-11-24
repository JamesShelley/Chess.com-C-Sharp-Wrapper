/*
 * A small minimal api example using our library.
 */

using ChessData.Library.Extensions;
using ChessData.Library.Interfaces;
using ChessData.Library.Core.Options;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Register our client
builder.Services.AddChessDataServices(new ChessDataRegistration
{
    //In this example, I am reading my personal access token from a secret
    LichessPersonalAccessToken = builder.Configuration["LichessToken"]
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Example -> get player profile data
app.MapGet("/player", async (IChesscomApi api, HttpContext httpContext, string name) => 
{
    var response = await api.GetPlayerProfileData(name);
    if (response == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(response);
});

//Example -> get all grandmasters
app.MapGet("/title", async (IChesscomApi api, HttpContext httpContext, string title) =>
{
    var response = await api.GetTitledPlayers(title);
    if (response == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(response);
});

//Example -> get streamers
app.MapGet("/streamers", async (IChesscomApi api, HttpContext httpContext) =>
{
    var response = await api.GetStreamers();
    if (response == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(response);
});

//Example -> Lichess Profile
app.MapGet("/lichess/account", async (ILiChessApi api, HttpContext httpContext) =>
{
    var response = await api.GetPlayerProfile();
    if (response == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(response);
});

app.Run();