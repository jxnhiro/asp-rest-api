
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api;

public class EntityFrameworkGamesRepository : IGamesRepository
{
    private readonly GameStoreContext dbContext;

    public EntityFrameworkGamesRepository(GameStoreContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public IEnumerable<Game> GetAll()
    {
        return dbContext.Games.AsNoTracking().ToList();
    }

    public Game? Get(int id)
    {
        return dbContext.Games.Find(id);
    }

    public void Create(Game game)
    {
        dbContext.Add(game);
        dbContext.SaveChanges();
    }

    public void Update(Game updatedGame)
    {
        dbContext.Update(updatedGame);
        dbContext.SaveChanges();
    }

    public void Delete(int id)
    {
        dbContext.Games.Where(game => game.Id == id)
                       .ExecuteDelete();
    }

    
}
