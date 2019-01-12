using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkyViews.Models
{
    public class Showing
    {
        public int ShowingID { get; set; }
        [ForeignKey("Room")]
        public int RoomID { get; set; }
        [ForeignKey("Film")]
        public int FilmID { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ShowingTime { get; set; }

        
        public virtual Room Room { get; set; }
        public virtual Film Film { get; set; }
    }
}
