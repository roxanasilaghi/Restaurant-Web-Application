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
    public class DetailsModel : PageModel
    {
        private readonly AplicatieWeb.Data.AplicatieWebContext _context;

        public DetailsModel(AplicatieWeb.Data.AplicatieWebContext context)
        {
            _context = context;
        }

        public Meniu Meniu { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Meniu = await _context.Meniu.FirstOrDefaultAsync(m => m.ID == id);

            if (Meniu == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
