using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstApproachEF.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("server=LAPTOP-81HIQF3R\\SQLEXPRESS; database=StudentDetails; trusted_connection=true")
        {

        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(s => new { s.StudentID });
        }
    }
}