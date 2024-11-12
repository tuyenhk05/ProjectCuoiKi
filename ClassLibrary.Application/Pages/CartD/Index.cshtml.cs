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
    public class IndexModel : PageModel
    {
        private readonly ICartDetail _service;
        public IndexModel(ICartDetail service)
        {
            _service = service;

        }

        public IList<CartDetail> CartDetail { get;set; } = default!;

        public async Task OnGetAsync()
        {
            CartDetail = await _service.CartDetails();
                
        }
    }
}
