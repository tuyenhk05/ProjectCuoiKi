using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ClassLibrary.Repositorries.Entities;

namespace RazorPagesMovie.Application.Pages.Accout
{
    public class CreateModel : PageModel
    {
        private readonly ClassLibrary.Repositorries.Entities.QuanliwedContext _context;

        public CreateModel(ClassLibrary.Repositorries.Entities.QuanliwedContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public KoiFish KoiFish { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.KoiFishes.Add(KoiFish);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
