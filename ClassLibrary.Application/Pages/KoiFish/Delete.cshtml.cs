using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Repositorries.Entities;

namespace RazorPagesMovie.Application.Pages.Accout
{
    public class DeleteModel : PageModel
    {
        private readonly ClassLibrary.Repositorries.Entities.QuanliwedContext _context;

        public DeleteModel(ClassLibrary.Repositorries.Entities.QuanliwedContext context)
        {
            _context = context;
        }

        [BindProperty]
        public KoiFish KoiFish { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var koifish = await _context.KoiFishes.FirstOrDefaultAsync(m => m.FishId == id);

            if (koifish == null)
            {
                return NotFound();
            }
            else
            {
                KoiFish = koifish;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var koifish = await _context.KoiFishes.FindAsync(id);
            if (koifish != null)
            {
                KoiFish = koifish;
                _context.KoiFishes.Remove(KoiFish);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
