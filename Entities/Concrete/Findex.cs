using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Findex : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal FindexScore { get; set; }

    }
}
