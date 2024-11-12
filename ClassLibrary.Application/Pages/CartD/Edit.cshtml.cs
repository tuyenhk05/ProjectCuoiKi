using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Repositorries.Entities;

namespace RazorPagesMovie.Application.Pages.CartD
{
    public class EditModel : PageModel
    {
        private readonly ClassLibrary.Repositorries.Entities.QuanliwedContext _context;

        public EditModel(ClassLibrary.Repositorries.Entities.QuanliwedContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CartDetail CartDetail { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartdetail =  await _context.CartDetails.FirstOrDefaultAsync(m => m.CartDetailId == id);
            if (cartdetail == null)
            {
                return NotFound();
            }
            CartDetail = cartdetail;
           ViewData["CartId"] = new SelectList(_context.ShoppingCarts, "CartId", "CartId");
           ViewData["FishId"] = new SelectList(_context.KoiFishes, "FishId", "FishId");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CartDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CartDetailExists(CartDetail.CartDetailId))
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

        private bool CartDetailExists(int id)
        {
            return _context.CartDetails.Any(e => e.CartDetailId == id);
        }
    }
}
