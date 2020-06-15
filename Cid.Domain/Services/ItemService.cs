using System;
using Cid.Domain.DTOs;
using Cid.Domain.Enums;
using Cid.Domain.Models;
using Cid.Domain.RepositoryContracts;

namespace Cid.Domain.Services
{
    public class ItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public void AddItem(ItemDTO dto)
        {
            var itemType = (ItemType)Enum.Parse(typeof(ItemType), dto.Type);

            // TODO: do mapping
            var item = new Item(dto.Name, itemType);
        }
    }
}