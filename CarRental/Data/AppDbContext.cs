using Microsoft.EntityFrameworkCore;
using CarRental.Models;

namespace CarRental.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Renters> Renters { get; set; }
        public DbSet<RentalRequest> RentalRequests { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Rentals> Rentals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>().HasData(
                new Car { CarId = 1, Brand = "Toyota", Model = "Vios", ImageUrl = "vios.jpg", RentalPrice = 2000m, Status = "Available" },
                new Car { CarId = 2, Brand = "Honda", Model = "City", ImageUrl = "city.jpg", RentalPrice = 2200m, Status = "Available" },
                new Car { CarId = 3, Brand = "Mitsubishi", Model = "Mirage G4", ImageUrl = "mirage.jpg", RentalPrice = 2000m, Status = "Available" },
                new Car { CarId = 4, Brand = "Nissan", Model = "Almera", ImageUrl = "almera.jpg", RentalPrice = 2300m, Status = "Available" },
                new Car { CarId = 5, Brand = "Ford", Model = "EcoSport", ImageUrl = "ecosport.jpg", RentalPrice = 2800m, Status = "Available" },
                new Car { CarId = 6, Brand = "Suzuki", Model = "Dzire", ImageUrl = "dzire.jpg", RentalPrice = 2000m, Status = "Available" },
                new Car { CarId = 7, Brand = "Hyundai", Model = "Accent", ImageUrl = "accent.jpg", RentalPrice = 2500m, Status = "Available" },
                new Car { CarId = 8, Brand = "Kia", Model = "Soluto", ImageUrl = "soluto.jpg", RentalPrice = 2300m, Status = "Available" },
                new Car { CarId = 9, Brand = "Chevrolet", Model = "Spark", ImageUrl = "spark.jpg", RentalPrice = 2200m, Status = "Available" },
                new Car { CarId = 10, Brand = "Mazda", Model = "2 Sedan", ImageUrl = "sedan.jpg", RentalPrice = 2400m, Status = "Available" },
                new Car { CarId = 11, Brand = "Subaru", Model = "XV", ImageUrl = "xv.jpg", RentalPrice = 3200m, Status = "Available" },
                new Car { CarId = 12, Brand = "Toyota", Model = "Avanza", ImageUrl = "avanza.jpg", RentalPrice = 3500m, Status = "Available" },
                new Car { CarId = 13, Brand = "Mitsubishi", Model = "Xpander", ImageUrl = "xpander.jpg", RentalPrice = 3800m, Status = "Available" },
                new Car { CarId = 14, Brand = "Suzuki", Model = "Ertiga", ImageUrl = "ertiga.jpg", RentalPrice = 3200m, Status = "Available" },
                new Car { CarId = 15, Brand = "Nissan", Model = "Livina", ImageUrl = "livina.jpg", RentalPrice = 3500m, Status = "Available" });
        }
    }
}
