using Cid.Domain.Entities;

namespace Cid.Domain.RepositoryContracts
{
    public interface IMovieRepository
    {
        void Add(Movie movie);
    }
}