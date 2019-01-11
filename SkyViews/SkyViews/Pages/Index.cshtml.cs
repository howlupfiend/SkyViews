﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SkyViews.Models;

namespace SkyViews.Pages
{
    public class IndexModel : PageModel
    {

        private readonly SkyViewsContext _context;

        public IndexModel(SkyViewsContext context)
        {
            _context = context;
        }


        public IList<Film> Film{ get; set; }
        public async Task OnGetAsync()
        {
            Film = await _context.Film.ToListAsync();

        }
    }
}
