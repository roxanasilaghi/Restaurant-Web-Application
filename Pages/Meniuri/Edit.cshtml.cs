using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AplicatieWeb.Data;
using AplicatieWeb.Models;

namespace AplicatieWeb.Pages.Meniuri
{
    public class EditModel : PageModel
    {
        private readonly AplicatieWeb.Data.AplicatieWebContext _context;

        public EditModel(AplicatieWeb.Data.AplicatieWebContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Meniu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MeniuExists(Meniu.ID))
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

        private bool MeniuExists(int id)
        {
            return _context.Meniu.Any(e => e.ID == id);
        }
    }
}
