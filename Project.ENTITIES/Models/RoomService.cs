using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
   public class RoomService:BaseEntity
    {
        public string Menu { get; set; }
        public string Beverage { get; set; }
        public decimal Price { get; set; }
        public string RoomNumber { get; set; }
        public int? ReservationID { get; set; }


        // relational
        public virtual Reservation Reservation { get; set; }
    }
}
