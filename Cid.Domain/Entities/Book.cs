using System;

namespace Cid.Domain.Entities
{
    public class Book : Item
    {
        public Book(string name, DateTime? finishedDate) : base(name, finishedDate)
        {
        }
    }
}