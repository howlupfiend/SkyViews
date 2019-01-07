using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SkyViews.Models;

namespace SkyViews.Pages.Showing
{
    public class EditModel : PageModel
    {
        private readonly SkyViews.Models.SkyViewsShowingsContext _context;

        public EditModel(SkyViews.Models.SkyViewsShowingsContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Showing).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShowingExists(Showing.ShowingID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ShowingExists(int id)
        {
            return _context.Showing.Any(e => e.ShowingID == id);
        }
    }
}
