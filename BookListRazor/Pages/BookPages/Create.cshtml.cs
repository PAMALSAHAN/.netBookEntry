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
        [BindProperty] // 
        public Book Cbook { get; set; } // methana Cbook kiyanne model eka 
        public void OnGet()
        {
        }

        // submit karapuwa ekiyanne data allaganna ekak hadanna one
        public async Task<IActionResult> OnPost() // event handler eka hadanakota hadanne mehemai on kiyana eka danna one
        {
            // api meka dan submit karama eka db ekaka save wenna one itin parameter eka vidihata book obj ekak yawanna one 
            // bt core wala tinawa bind property eken uda tina property eka bind karala ganna puluwan
            if (ModelState.IsValid)
            {
              
                await _db.BookModelProperty.AddAsync(Cbook);// methana danna one book model eken hadapu eka 
                // maka hariyata nikan read ekak wage thama db ekata watila naha eka hinda 
                await _db.SaveChangesAsync();
               
                return RedirectToPage("Index");
            }
            else
            {
                return Page(); // page ekema tiyagannawa 
            }

        }
        
    }
}
