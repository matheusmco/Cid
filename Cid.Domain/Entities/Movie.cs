using System;

namespace Cid.Domain.Entities
{
    public class Movie : Item
    {
        public Movie(string name, DateTime? finishedDate) : base(name, finishedDate)
        {
        }
    }
}