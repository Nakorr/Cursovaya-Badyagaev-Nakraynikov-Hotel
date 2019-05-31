using HotelRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModel
{
    public class Design
    {
        public int Id { get; set; }
        public int HRoomId { get; set; }
        public int RoomId { get; set; }
        public int Count { get; set; }
        public string Window { get; set; }
        public int Floor { get; set; }
        public virtual HRoom HRoom { get; set; }
        public virtual Room Room { get; set; }
    }
}
