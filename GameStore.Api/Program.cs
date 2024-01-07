using GameStore.Api;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IGamesRepository, InMemGamesRepository>();
var app = builder.Build();

app.MapGamesEndpoints();

app.Run();
