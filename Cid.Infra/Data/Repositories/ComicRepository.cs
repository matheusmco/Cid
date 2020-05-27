using Cid.Domain.Entities;
using Cid.Infra.Data.Contracts;

namespace Cid.Infra.Data.Repositories
{
    public class ComicRepository : IComicRepository
    {
        private readonly DatabaseContext _dbcontext;
        private readonly IRepository<Comic> _repository;
        public ComicRepository(DatabaseContext databaseContext, IRepository<Comic> repository)
        {
            _dbcontext = databaseContext;
            _repository = repository;
        }

        public void Add(Comic comic) => _repository.Add(comic);
    }
}