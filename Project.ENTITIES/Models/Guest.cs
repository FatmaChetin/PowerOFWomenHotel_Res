using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Guest:BaseEntity
    { // bu Classla müşterinin rezervasyonu başkaları adına yaptıgı durumlarda, odada konaklayacak kisilerin bilgileri alınacaktır 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string TCKNo { get; set; }
        public string RoomNumber { get; set; }
        // relational
        public virtual List<GuestDetail> GuestDetails { get; set; } // Guest ve Reservation Classlarının Junction table listesi
    }
}
