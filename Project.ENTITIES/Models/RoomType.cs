using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class RoomType:BaseEntity
    {
        public string TypeName { get; set; }
        public decimal PricePerNight { get; set; }
        public string Description { get; set; }




        //relational

        public virtual List<Room> Rooms { get; set; }
    }
}
