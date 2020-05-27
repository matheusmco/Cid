using Cid.Domain.Entities;

namespace Cid.Infra.Data.Contracts
{
    public interface IGameRepository
    {
        void Add(Game game);
    }
}