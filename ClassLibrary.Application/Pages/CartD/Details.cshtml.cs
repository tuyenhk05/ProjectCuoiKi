using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Repositorries.Entities;

namespace RazorPagesMovie.Application.Pages.CartD
{
    public class DetailsModel : PageModel
    {
        private readonly ClassLibrary.Repositorries.Entities.QuanliwedContext _context;

        public DetailsModel(ClassLibrary.Repositorries.Entities.QuanliwedContext context)
        {
            _context = context;
        }

        public CartDetail CartDetail { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartdetail = await _context.CartDetails.FirstOrDefaultAsync(m => m.CartDetailId == id);
            if (cartdetail == null)
            {
                return NotFound();
            }
            else
            {
                CartDetail = cartdetail;
            }
            return Page();
        }
    }
}
