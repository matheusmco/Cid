using System;

namespace Cid.Domain.Entities
{
    public class Series : Item
    {
        public Series(string name, DateTime? finishedDate) : base(name, finishedDate)
        {
        }
    }
}