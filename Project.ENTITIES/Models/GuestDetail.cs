using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class GuestDetail:BaseEntity
    {
        public int GuestID { get; set; }
        public int ReservationID { get; set; }


        //Relational Properties
        public virtual Guest Guest { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
