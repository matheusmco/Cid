using System;
using Cid.Domain.DTOs;
using Cid.Domain.RepositoryContracts;
using Cid.Domain.Services;
using Moq;
using NUnit.Framework;
using FluentAssertions;

namespace Cid.Tests.Domain.Services
{
    public class ItemServiceTests
    {
        // TODO: move to model test
        [Test]
        public void AddItem_ItemTypeNotExists_Throw()
        {
            var service = CreateService();
            var dto = new ItemDTO
            {
                Type = "INVALID_ONE"
            };
            Action act = () => service.AddItem(dto);
            act.Should().Throw<ArgumentException>().WithMessage("Requested value 'INVALID_ONE' was not found");
        }

        [Test]
        public void AddItem_Ok_Add()
        {
            var service = CreateService();
            var dto = new ItemDTO
            {
                Type = "INVALID_ONE"
            };
            Action act = () => service.AddItem(dto);
            act.Should().Throw<ArgumentException>().WithMessage("Requested value 'INVALID_ONE' was not found");
        }

        public ItemService CreateService()
        {
            var repositoryMock = new Mock<IItemRepository>();
            return new ItemService(repositoryMock.Object);
        }
    }
}