using System;
using AutoMapper;
using Cid.Domain.DTOs;
using Cid.Domain.Enums;
using Cid.Domain.Models;
using Cid.Domain.RepositoryContracts;
using Cid.Domain.Services.Contracts;

namespace Cid.Domain.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public void AddItem(ItemDTO dto)
        {
            // TODO: move to model
            var itemType = (ItemType)Enum.Parse(typeof(ItemType), dto.Type);
            var item = new Item(dto.Name, itemType);
            _itemRepository.Add(item);
        }
    }
}