namespace Application.Games.Queries;

public class GetAllGames : IRequest<IEnumerable<Game>>
{
    public class GetAllGamesHandler : IRequestHandler<GetAllGames, IEnumerable<Game>>
    {
        private readonly IWerewolfContext _context;
        public GetAllGamesHandler(IWerewolfContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Game>> Handle(GetAllGames query, CancellationToken cancellationToken)
        {
            var gameList = await _context.Games.Take(10).ToListAsync(cancellationToken);
            if (gameList == null)
            {
                return new List<Game>();
            }
            return gameList.AsReadOnly();
        }
    }
}
