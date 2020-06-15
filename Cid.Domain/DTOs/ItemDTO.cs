using System;

namespace Cid.Domain.DTOs
{
    public class ItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? FinishedDate { get; set; }
        public string Type { get; set; }
    }
}