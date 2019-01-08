using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SkyViews.Models;

namespace SkyViews.Pages.Showings
{
    public class DetailsModel : PageModel
    {
        private readonly SkyViews.Models.SkyViewsShowingsContext _context;

        public DetailsModel(SkyViews.Models.SkyViewsShowingsContext context)
        {
            _context = context;
        }

        public Showing Showing { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Showing = await _context.Showing.FirstOrDefaultAsync(m => m.ShowingID == id);

            if (Showing == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
