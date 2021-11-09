using Domain.Entities;

namespace WebApi;

public class Query
{
    public IQueryable<Game> GetGames() => new List<Game>().AsQueryable();
}
