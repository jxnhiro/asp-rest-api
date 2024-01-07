using GameStore.Api;

List<Game> games = new()
{
    new Game()
    {
        Id = 1,
        Name = "Street Fighter 2",
        Genre = "Fighting",
        Price = 19.99M,
        ReleaseDate = new DateTime(1991, 2, 1),
        ImageUri = "https://placehold.co/100"
    },
    new Game()
    {
        Id = 2,
        Name = "Final Fantasy 14",
        Genre = "Fighting",
        Price = 59.99M,
        ReleaseDate = new DateTime(2010, 9, 28),
        ImageUri = "https://placehold.co/100"
    },
    new Game()
    {
        Id = 3,
        Name = "FIFA 2023",
        Genre = "Sports",
        Price = 69.99M,
        ReleaseDate = new DateTime(2022, 9, 27),
        ImageUri = "https://placehold.co/100"
    },
};

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/games", () => games);
app.MapGet("/games/{id}", (int id) => {
    Game? game = games.Find(game => game.Id == id);
    if (game is null)
    {
        return Results.NotFound();
    }
    return Results.Ok(game);
});

app.Run();
