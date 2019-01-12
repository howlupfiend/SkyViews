using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SkyViews.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        [ForeignKey("ShowingID")]
        public int ShowingID { get; set; }
        public int SeatNo { get; set; }


       
        public virtual Showing Showing { get; set; }
    }
}
