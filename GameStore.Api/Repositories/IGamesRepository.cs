namespace GameStore.Api;

public interface IGamesRepository
{
    IEnumerable<Game> GetAll();
    Game? Get(int id);
    void Create(Game game);
    void Update(Game updatedGame);
    void Delete(int id);
}
