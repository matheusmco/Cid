using Cid.Domain.Entities;

namespace Cid.Infra.Data.Contracts
{
    public interface IComicRepository
    {
        void Add(Comic comic);
    }
}