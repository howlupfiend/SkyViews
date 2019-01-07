using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkyViews.Models
{
    public class Bookings
    {
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public int RoomID { get; set; }
        public int ShowingID { get; set; }
        public int SeatNo { get; set; }
    }
}
