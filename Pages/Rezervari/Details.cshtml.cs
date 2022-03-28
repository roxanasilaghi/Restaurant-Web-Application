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
    public class DetailsModel : PageModel
    {
        private readonly AplicatieWeb.Data.AplicatieWebContext _context;

        public DetailsModel(AplicatieWeb.Data.AplicatieWebContext context)
        {
            _context = context;
        }

        public Rezervare Rezervare { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rezervare = await _context.Rezervare.FirstOrDefaultAsync(m => m.ID == id);

            if (Rezervare == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
