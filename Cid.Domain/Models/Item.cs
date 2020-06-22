using System;
using Cid.Domain.Enums;

namespace Cid.Domain.Models
{
    public class Item
    {
        public int ID { get; protected set; }
        public string Name { get; protected set; }
        public ItemType Type { get; protected set; }
        public DateTime? FinishedDate { get; protected set; }
        public bool IsUnfinished => !FinishedDate.HasValue;

        Item() { }

        public Item(string name, ItemType type, DateTime? finishedDate = null)
        {
            // TODO: validate name
            Name = name;

            // TODO: validate type
            Type = type;

            // TODO: validate finished date greater than today
            FinishedDate = finishedDate;
        }
    }
}