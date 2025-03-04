using Microsoft.EntityFrameworkCore;

namespace CarRental.Entities
{
    public class AccesDb : DbContext
    {
        public AccesDb(DbContextOptions<AccesDb> options) : base(options)
        {

        }

        public DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
