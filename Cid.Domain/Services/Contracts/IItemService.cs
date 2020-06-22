using Cid.Domain.DTOs;

namespace Cid.Domain.Services.Contracts
{
    public interface IItemService
    {
        void AddItem(ItemDTO dto);
    }
}