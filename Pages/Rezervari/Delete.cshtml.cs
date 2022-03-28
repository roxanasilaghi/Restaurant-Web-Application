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
    public class DeleteModel : PageModel
    {
        private readonly AplicatieWeb.Data.AplicatieWebContext _context;

        public DeleteModel(AplicatieWeb.Data.AplicatieWebContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rezervare = await _context.Rezervare.FindAsync(id);

            if (Rezervare != null)
            {
                _context.Rezervare.Remove(Rezervare);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
