using Cid.Domain.Models;

namespace Cid.Domain.RepositoryContracts
{
    public interface IItemRepository
    {
        void Add(Item item);
    }
}