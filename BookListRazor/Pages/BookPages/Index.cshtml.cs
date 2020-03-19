using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


//Book Pages Folder
namespace BookListRazor.BookPages
{
    public class IndexModel : PageModel 
    {
        //db ekka connec eka hadaganna tinne
        public readonly AppDbContext _db;
        public IndexModel(AppDbContext db) // this is from dependancy injection
        {
            _db = db;

        }

        public IEnumerable<Book> IBook { get; set; }   //for loop ekak yanna one nisa 

        public async Task OnGet() // mathana get kiyanne handler ekak 
        {
            IBook = await _db.BookModelProperty.ToListAsync();  //table eken list ekata dagannawa BookModelProperty kiyanne table name eka
        }
    }
}
