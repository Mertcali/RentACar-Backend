using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto:IDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int UserId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string CarName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal CarDailyPrice { get; set; }
        public string CarModelYear { get; set; }
        public string CarDescription { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }

    }
}
