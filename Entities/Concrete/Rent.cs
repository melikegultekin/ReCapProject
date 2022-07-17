using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Rent:IEntity
    {
        public int RentId { get; set; }

        public sting CustomerId { get; set; }

        public int EmployeeId { get; set; }

        public DateTime RentDate { get; set; }

        public string ShipCity { get; set; }
    }
}
