using System;

namespace Cid.Domain.Entities
{
    public class Item
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public DateTime? FinishedDate { get; protected set; }
        public bool IsUnfinished => !FinishedDate.HasValue;

        public Item(string name, DateTime? finishedDate)
        {
            Name = name;
            FinishedDate = finishedDate;
        }
    }
}