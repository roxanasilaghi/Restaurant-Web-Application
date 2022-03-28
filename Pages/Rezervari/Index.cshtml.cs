using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AplicatieWeb.Data;
using AplicatieWeb.Models;

namespace AplicatieWeb.Pages.Rezervari
{
    public class IndexModel : PageModel
    {
        private readonly AplicatieWeb.Data.AplicatieWebContext _context;

        public IndexModel(AplicatieWeb.Data.AplicatieWebContext context)
        {
            _context = context;
        }

        public IList<Rezervare> Rezervare { get;set; }

        public async Task OnGetAsync()
        {
            Rezervare = await _context.Rezervare
                
                .ToListAsync();
        }
    }
}
