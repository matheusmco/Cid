using Cid.Domain.Entities;
using Cid.Infra.Data.Contracts;

namespace Cid.Infra.Data.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly DatabaseContext _databaseContext;
        private readonly IRepository<Game> _repository;

        public GameRepository(DatabaseContext databaseContext, IRepository<Game> repository)
        {
            _databaseContext = databaseContext;
            _repository = repository;
        }

        public void Add(Game game) => _repository.Add(game);
    }
}