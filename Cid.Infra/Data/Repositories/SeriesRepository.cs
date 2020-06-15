using Cid.Domain.Models;
using Cid.Domain.RepositoryContracts;
using Cid.Infra.Data.Contracts;

namespace Cid.Infra.Data.Repositories
{
    public class SeriesRepository : IItemRepository
    {
        private readonly DatabaseContext _databaseContext;
        private readonly IRepository<Item> _repository;

        public SeriesRepository(DatabaseContext databaseContext, IRepository<Item> repository)
        {
            _databaseContext = databaseContext;
            _repository = repository;
        }

        public void Add(Item item) => _databaseContext.Add(item);
    }
}