using GameStore.Api;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IGamesRepository, InMemGamesRepository>();

var connString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddSqlServer<GameStoreContext>(connString);

var app = builder.Build();
app.MapGamesEndpoints();

app.Run();
