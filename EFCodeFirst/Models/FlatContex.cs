using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstApproachEF.Models
{
    public class FlatContex : DbContext
    {
        public FlatContex() : base("server=LAPTOP-81HIQF3R\\SQLEXPRESS; database=FlatDetails; trusted_connection=true")
        {

        }

        public DbSet<Flat> Flats { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flat>().HasKey(f => new { f.FlatNumber });
        }
    }
}