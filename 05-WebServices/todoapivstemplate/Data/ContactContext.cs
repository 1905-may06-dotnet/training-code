using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class ContactContext:DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options):base(options)
        {

        }
        public DbSet<ContactUser> ContactUser { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactUser>().HasData(new List<ContactUser>
            {
                new ContactUser{Id=1, FirstName="Fred", LastName="Belotte", Mobile="9876543212", Email="fred@revature.com"},
                new ContactUser{Id=2, FirstName="Carol", LastName="Baxtor", Mobile="9234567876", Email="carol.baxtor@revature.com"}
            });
            //base.OnModelCreating(modelBuilder);
        }
    }
}
