using Cid.Domain.Entities;

namespace Cid.Domain.RepositoryContracts
{
    public interface IComicRepository
    {
        void Add(Comic comic);
    }
}