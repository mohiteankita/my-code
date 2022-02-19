using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstApproachEF.Models
{
    public class BookContext : DbContext
    {
        public BookContext() : base("server=LAPTOP-81HIQF3R\\SQLEXPRESS; database=Book; trusted_connection=true")
        {

        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasKey(b => new { b.BookID });
        }
    }
}