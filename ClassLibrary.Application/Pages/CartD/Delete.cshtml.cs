using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Repositorries.Entities;
using ClassLibrary.Services.Interfaces;

namespace RazorPagesMovie.Application.Pages.CartD
{
    public class DeleteModel : PageModel
    {
        private readonly ICartDetail _service;
        public DeleteModel(ICartDetail service)
        {
            _service = service;
        }

        [BindProperty]
        public CartDetail CartDetail { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            int Id = 0;
            if (id == null)
            {
                Id = 0;
                return NotFound();
            }
            Id = (int)id;

            var cartdetail = await _service.GetCartDetailById(Id);

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

        public Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return Task.FromResult<IActionResult>(NotFound());
            }

            _service.DelCartDetail((int)id);
            

            return Task.FromResult<IActionResult>(RedirectToPage("./Index"));
        }
    }
}
