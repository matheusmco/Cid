using Cid.Domain.Entities;

namespace Cid.Infra.Data.Contracts
{
    public interface IBookRepository
    {
        void Add(Book book);
    }
}