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
        // db eka hadanne naththam front eke awlak yanawa eka nisa eka hadanna one
        private readonly AppDbContext _db;

        public EditModel(AppDbContext db)
        {
            _db = db;
        }
        [BindProperty] //meka danna mokada db eka bind karanne meken
        public Book EBook { get; set; } //book model eken obj ekak hadaganna eka thama karanne

        public async Task OnGet(int id)
        {
            EBook = await _db.BookModelProperty.FindAsync(id);
        }

        public async Task<IActionResult> OnPost(int id)
        {
            if (ModelState.IsValid)
            {
                var eBookFromDb=await _db.BookModelProperty.FindAsync(EBook.Id);         // mathana tinne id eka hidden karanna issella eka
                eBookFromDb.Name = EBook.Name;
                eBookFromDb.Author = EBook.Author;
                eBookFromDb.ISBN = EBook.ISBN;

                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }

    }
}
