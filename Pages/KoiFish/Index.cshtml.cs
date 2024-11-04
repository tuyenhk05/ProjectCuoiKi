using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Repositorries.Entities;
using ClassLibrary.Repositorries.Interfaces;
using ClassLibrary.Services.Services;
using ClassLibrary.Services.Interfaces;

namespace RazorPagesMovie.Application.Pages.Accout
{
    public class IndexModel : PageModel
    {
        private readonly IKoifish _service;
        public IndexModel(IKoifish service)
        {
            _service =service ;
        }

        public IList<KoiFish> KoiFish { get;set; } = default!;

        public async Task OnGetAsync()
        {
            KoiFish = await _service.KoiFishs();
        }
    }
}
