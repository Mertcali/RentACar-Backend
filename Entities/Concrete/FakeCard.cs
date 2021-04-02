using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class FakeCard:IEntity
    {
        public int Id { get; set; }
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public string CardCVV { get; set; }
        public string ExpirationDate { get; set; }
        public decimal MoneyInCard { get; set; }
    }
}
