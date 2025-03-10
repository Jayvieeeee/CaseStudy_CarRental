using CarRental.Data;
using CarRental.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Controllers
{
    public class RentalRequestController : Controller
    {
        private readonly AppDbContext _context;

        public RentalRequestController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateRentalRequest(int carId, DateTime rentalDate, DateTime returnDate)
        {
            var user = _context.UserAccounts.FirstOrDefault(u => u.Username == User.Identity.Name);

            if (user == null)
            {
                return NotFound("User not found");
            }

            var car = _context.Cars.FirstOrDefault(c => c.CarId == carId);

            if (car == null)
            {
                return NotFound("Car not found");
            }

            int days = (returnDate - rentalDate).Days;
            decimal estimatedPrice = car.RentalPrice * days; 

            var rentalRequest = new RentalRequest
            {
                RenterId = user.Id,
                CarId = carId,
                RentalDate = rentalDate,
                ReturnDate = returnDate,
                EstimatedPrice = estimatedPrice,
                Status = "Pending" 
            };

            _context.RentalRequests.Add(rentalRequest);
            _context.SaveChanges();

            return Ok(new { message = "Rental request submitted", estimatedPrice });
        }

    }
}
