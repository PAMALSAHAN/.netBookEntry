using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.model
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt): base(opt) // parameter is needed for dependancy injection
        {
                
        }

        // need to add book model to the database
        public DbSet<Book> BookModelProperty { get; set; }  //table name eka thamai BookModelProperty meka

    }
}
