using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto:IDto
    {
        public string CarName { get; set; }
        public decimal DailyPrice { get; set; }
        public string BrandName { get; set; }
        public DateTime RentDate { get; set; }

    }
}
