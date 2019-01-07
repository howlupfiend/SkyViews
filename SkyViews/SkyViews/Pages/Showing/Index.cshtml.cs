using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SkyViews.Models;

namespace SkyViews.Pages.Showing
{
    public class IndexModel : PageModel
    {
        private readonly SkyViews.Models.SkyViewsShowingsContext _context;

        public IndexModel(SkyViews.Models.SkyViewsShowingsContext context)
        {
            _context = context;
        }

        public IList<Showing> Showing { get;set; }

        public async Task OnGetAsync()
        {
            Showing = await _context.Showing.ToListAsync();
        }
    }
}
