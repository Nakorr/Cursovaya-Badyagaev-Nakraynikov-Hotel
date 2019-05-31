using HotelModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomName { get; set; }
        public virtual List<Design> Designs { get; set; }
    }
}