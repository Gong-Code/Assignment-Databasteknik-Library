#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Library_inlämningsuppgift.Data;
using Library_inlämningsuppgift.Models;

namespace Library_inlämningsuppgift.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Library_inlämningsuppgift.Data.ApplicationDbContext _context;

        public IndexModel(Library_inlämningsuppgift.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; }

        public async Task OnGetAsync()
        {
            Author = await _context.Authors.ToListAsync();
        }
    }
}
