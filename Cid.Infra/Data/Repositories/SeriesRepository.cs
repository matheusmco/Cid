using Cid.Domain.Entities;
using Cid.Domain.RepositoryContracts;
using Cid.Infra.Data.Contracts;

namespace Cid.Infra.Data.Repositories
{
    public class SeriesRepository : ISeriesRepository
    {
        private readonly DatabaseContext _databaseContext;
        private readonly IRepository<Series> _repository;

        public SeriesRepository(DatabaseContext databaseContext, IRepository<Series> repository)
        {
            _databaseContext = databaseContext;
            _repository = repository;
        }

        public void Add(Series series) => _databaseContext.Add(series);
    }
}