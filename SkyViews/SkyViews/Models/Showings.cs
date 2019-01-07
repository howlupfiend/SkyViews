using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SkyViews.Models
{
    public class Showings
    {
        public int ShowingID { get; set; }
        public int RoomID { get; set; }
        public int FilmID { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ShowingTime { get; set; }
    }
}
