#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Library_inlämningsuppgift.Data;
using Library_inlämningsuppgift.Models;
using System.ComponentModel.DataAnnotations;

namespace Library_inlämningsuppgift.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Library_inlämningsuppgift.Data.ApplicationDbContext _context;

        public CreateModel(Library_inlämningsuppgift.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["Author"] = new SelectList(_context.Authors.OrderBy(x => x.AuthorName), nameof(Author.Id), nameof(Author.AuthorName));
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Author is required.")]
        public int AuthorId { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var author = _context.Authors.First(x => x.Id == AuthorId);
            Book.Author = author;

            _context.Books.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
