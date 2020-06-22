using Cid.Domain.Enums;
using Cid.Domain.Models;
using NUnit.Framework;

namespace Cid.Tests.Domain.Models
{
    public class ItemTests
    {
        [Test]
        public void FinishedDateIsNull_IsItemUnfinished()
        {
            var item = new Item(null, default(ItemType));

            Assert.IsTrue(item.IsUnfinished);
        }

        // TODO: check for item without name
        // TODO: check for item without type
    }
}