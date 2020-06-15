using Cid.Domain.Enums;
using Cid.Domain.Models;
using NUnit.Framework;

namespace Cid.Tests.Domain
{
    public class ItemTests
    {
        [Test]
        public void FinishedDateIsNull_IsItemUnfinished()
        {
            var item = new Item(null, default(ItemType));

            Assert.IsTrue(item.IsUnfinished);
        }
    }
}