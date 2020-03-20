using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookPages
{
    public class CreateModel : PageModel
    {
        //mketh db context ekak hadanna one mokada kiyanawanam db ekata submit karama data yanna onene ekai
        //db eken deyak gannawanam hari danawanam hari db ekath ekka connection ekak hadaganna one
        public readonly AppDbContext _db;
        public CreateModel(AppDbContext db)
        {
            _db = db;
        }
        // ita passe tinne model ekak hadana eka
        public Book Cbook { get; set; } // methana Cbook kiyanne model eka 
        public void OnGet()
        {
        }
    }
}
