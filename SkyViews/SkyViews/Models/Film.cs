using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SkyViews.Models
{
    public class Film
    {
        public int FilmID { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string RunningTime { get; set; }
        public string Director { get; set; }
        public string Cast { get; set; }
        public string ImagePath { get; set; }

        public virtual ICollection<Showing> Showing { get; set; }
    }


}
