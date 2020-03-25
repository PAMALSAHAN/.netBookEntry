using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookPages
{
    public class EditModel : PageModel
    {
        private readonly AppDbContext _db;

        public EditModel(AppDbContext db)
        {
            _db = db;
        }

        public Book EBook { get; set; } //book model eken obj ekak hadaganna eka thama karanne

        public async Task OnGet(int id)
        {
            EBook = await _db.BookModelProperty.FindAsync(id);
        }
    }
}
