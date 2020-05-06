using System;

namespace Cid.Domain.Entities
{
    public abstract class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? FinishedDate { get; set; }
        public bool IsUnfinished => !FinishedDate.HasValue;
    }
}