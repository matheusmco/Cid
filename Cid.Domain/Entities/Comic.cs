using System;

namespace Cid.Domain.Entities
{
    public class Comic : Item
    {
        public Comic(string name, DateTime? finishedDate) : base(name, finishedDate)
        {
        }
    }
}