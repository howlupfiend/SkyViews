using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SkyViews.Models;

namespace SkyViews.Pages
{
    public class BookingModel : PageModel
    {
        private readonly SkyViewsContext _context;

        public BookingModel(SkyViewsContext context)
        {
            _context = context;
        }

        public Booking Booking { get; set; }
//        public async Task<IActionResult> OnGetAsync(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            
//            }


//        }
    }
}