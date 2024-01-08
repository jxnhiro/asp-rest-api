using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

namespace GameStore.Api;

public class GameStoreContext : DbContext
{
    public GameStoreContext(DbContextOptions<GameStoreContext> options) : base(options){}
    public DbSet<Game> Games { get; set; }
}
