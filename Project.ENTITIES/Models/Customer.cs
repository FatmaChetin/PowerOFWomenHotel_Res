using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Customer:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string TCKNo { get; set; }
        public string Adress { get; set; }

        //Relational properties
        public virtual List<Reservation> Reservations { get; set; } //Müsterinin rezervasyon listesi     
    }
}
