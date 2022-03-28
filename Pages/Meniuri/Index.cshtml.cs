using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AplicatieWeb.Data;
using AplicatieWeb.Models;

namespace AplicatieWeb.Pages.Meniuri
{
    public class IndexModel : PageModel
    {
        private readonly AplicatieWeb.Data.AplicatieWebContext _context;

        public IndexModel(AplicatieWeb.Data.AplicatieWebContext context)
        {
            _context = context;
        }

        public IList<Meniu> Meniu { get;set; }

        public async Task OnGetAsync()
        {
            Meniu = await _context.Meniu.ToListAsync();
        }
    }
}
