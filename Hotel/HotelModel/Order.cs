using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModel
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int HRoomId { get; set; }
        public int HRoomCount { get; set; }
        public decimal Sum { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateImplement { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual HRoom HRoom { get; set; }
    }
}
