using Cid.Domain.Entities;

namespace Cid.Domain.RepositoryContracts
{
    public interface IBookRepository
    {
        void Add(Book book);
    }
}