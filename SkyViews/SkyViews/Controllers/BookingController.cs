using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkyViews.Controllers
{
    [Route("[controller]/[action]")]
    public class BookingController : Controller
    {   
        public async Task<IActionResult> CreatingBooking()
        {
            
            return RedirectToPage("/Booking");
        }
    }
}