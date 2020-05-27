using System;

namespace Cid.Domain.Entities
{
    public class Game : Item
    {
        public Game(string name, DateTime? finishedDate) : base(name, finishedDate)
        {
        }
    }
}