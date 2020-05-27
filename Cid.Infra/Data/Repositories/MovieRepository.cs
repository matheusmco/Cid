using Cid.Domain.Entities;
using Cid.Infra.Data.Contracts;

namespace Cid.Infra.Data.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DatabaseContext _databaseContext;
        private readonly IRepository<Movie> _repository;

        public MovieRepository(DatabaseContext databaseContext, IRepository<Movie> repository)
        {
            _databaseContext = databaseContext;
            _repository = repository;
        }

        public void Add(Movie movie) => _repository.Add(movie);
    }
}