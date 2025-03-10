using CarRental.Data;
using CarRental.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CarRental.Controllers
{
    public class AdminCarController : Controller
    {
        private readonly AppDbContext _context;

        public AdminCarController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var cars = _context.Cars.ToList();
            return View(cars);
        }


        [HttpPost]
        public IActionResult AddCar(string brand, string model, int seaters, decimal rentalPrice, string imageUrl)
        {
            var car = new Car
            {
                Brand = brand,
                Model = model,
                Seaters = seaters,
                RentalPrice = rentalPrice,
                ImageUrl = imageUrl,
                Status = "Available"
            };

            _context.Cars.Add(car);
            _context.SaveChanges();

            return Ok(new { message = "Car added successfully" });
        }

       
        [HttpPost]
        public IActionResult UpdateCar(int carId, string brand, string model, int seaters, decimal rentalPrice, string imageUrl, string status)
        {
            var car = _context.Cars.FirstOrDefault(c => c.CarId == carId);

            if (car == null)
            {
                return NotFound("Car not found");
            }

            car.Brand = brand;
            car.Model = model;
            car.Seaters = seaters;
            car.RentalPrice = rentalPrice;
            car.ImageUrl = imageUrl;
            car.Status = status;

            _context.SaveChanges();

            return Ok(new { message = "Car updated successfully" });
        }

        [HttpPost]
        public IActionResult DeleteCar(int carId)
        {
            var car = _context.Cars.FirstOrDefault(c => c.CarId == carId);

            if (car == null)
            {
                return NotFound("Car not found");
            }

            _context.Cars.Remove(car);
            _context.SaveChanges();

            return Ok(new { message = "Car deleted successfully" });
        }
    }
}
