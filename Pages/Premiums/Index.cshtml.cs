using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using crud_interface.Data;
using crud_interface.Models;

namespace crud_interface.Pages_Premiums
{
    public class IndexModel : PageModel
    {
        private readonly crud_interface.Data.ApplicationDbContext _context;

        public IndexModel(crud_interface.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<Premium> Premium { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Premium = await _context.Premium
                .Include(p => p.Student).ToListAsync();
        }
    }
}
