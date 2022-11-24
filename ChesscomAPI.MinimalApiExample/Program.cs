/*
 * A small minimal api example using our library.
 */

using ChesscomAPI.Library.Constants;
using ChesscomAPI.Library.Extensions;
using ChesscomAPI.Library.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddChesscomClient();

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
    var response = await api.GetTitledPlayers(ChessTitles.GRANDMASTER);
    if (response == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(response);
});

//Example -> get streams
app.MapGet("/streamers", async (IChesscomApi api, HttpContext httpContext, string title) =>
{
    var response = await api.GetStreamers();
    if (response == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(response);
});

app.Run();