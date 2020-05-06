using Cid.Domain.Entities;
using NUnit.Framework;

namespace Cid.Tests.Domain
{
    public class ItemTests
    {
        [Test]
        public void FinishedDateIsNull_IsItemUnfinished()
        {
            var item = new Book
            {
                FinishedDate = null
            };

            Assert.IsTrue(item.IsUnfinished);
        }
    }
}