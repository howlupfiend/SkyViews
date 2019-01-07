using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SkyViews.Models;

namespace SkyViews.Pages.Showing
{
    public class CreateModel : PageModel
    {
        private readonly SkyViews.Models.SkyViewsShowingsContext _context;

        public CreateModel(SkyViews.Models.SkyViewsShowingsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Showing Showing { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Showing.Add(Showing);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}