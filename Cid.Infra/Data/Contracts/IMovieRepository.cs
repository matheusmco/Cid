using Cid.Domain.Entities;

namespace Cid.Infra.Data.Contracts
{
    public interface IMovieRepository
    {
        void Add(Movie movie);
    }
}