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
    public class DeleteModel : PageModel
    {
        private readonly SkyViews.Models.SkyViewsShowingsContext _context;

        public DeleteModel(SkyViews.Models.SkyViewsShowingsContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Showing = await _context.Showing.FindAsync(id);

            if (Showing != null)
            {
                _context.Showing.Remove(Showing);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
