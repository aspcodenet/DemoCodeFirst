using Microsoft.EntityFrameworkCore;

namespace DemoCodeFirst.Models
{
    public class MyContext : DbContext
    {
        public MyContext()
        {
            
        }

        public MyContext(DbContextOptions<MyContext> options)
            :base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=localhost;initial catalog=youtubedemo1;integrated security=true");
            }
        }


        public DbSet<UserAccount> Accounts { get;set; }
        public DbSet<Invoice> Invoices { get; set; }
    }
}