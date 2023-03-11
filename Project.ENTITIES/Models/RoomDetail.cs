using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class RoomDetail:BaseEntity
    { // Room and Reservation is ManyToMany
        public int RoomID { get; set; }
        public int ReservationID { get; set; }

        //Relational Properties
        public virtual Room Room { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
