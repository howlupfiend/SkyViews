using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
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

        public Film Film { get; set; }

        public async Task OnGetAsync(int? id)
        {
            Film = await _context.Film.Include(s => s.Showing).AsNoTracking().FirstOrDefaultAsync(m => m.FilmID == id);

        }
    }
}