using CarRental.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRental.Data;

namespace CarRental.Controllers
{
    public class AdminRentalController : Controller
    {
        private readonly AppDbContext _context; 


        public AdminRentalController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ApproveRental(int requestId)
        {
            var rentalRequest = _context.RentalRequests.FirstOrDefault(r => r.RequestId == requestId);

            if (rentalRequest == null)
            {
                return NotFound("Rental request not found");
            }

            rentalRequest.Status = "Approved";

            var rental = new Rentals
            {
                RenterId = rentalRequest.RenterId,
                CarId = rentalRequest.CarId,
                RentalDate = rentalRequest.RentalDate,
                ReturnDate = rentalRequest.ReturnDate,
                TotalPrice = rentalRequest.EstimatedPrice,
                Status = "On-going"
            };

            _context.Rentals.Add(rental);
            _context.SaveChanges();

            return Ok(new { message = "Rental approved" });
        }

        [HttpPost]
        public IActionResult RejectRental(int requestId)
        {
            var rentalRequest = _context.RentalRequests.FirstOrDefault(r => r.RequestId == requestId);

            if (rentalRequest == null)
            {
                return NotFound("Rental request not found");
            }

            rentalRequest.Status = "Rejected"; 
            _context.SaveChanges();

            return Ok(new { message = "Rental request rejected" });
        }

        [HttpPost]
        public IActionResult CompleteRental(int rentalId)
        {
            var rental = _context.Rentals.FirstOrDefault(r => r.RentalId == rentalId);

            if (rental == null)
            {
                return NotFound("Rental not found");
            }

            rental.Status = "Completed"; 
            _context.SaveChanges();

            return Ok(new { message = "Rental marked as completed" });
        }

        [HttpPost]
        public IActionResult CancelRental(int rentalId)
        {
            var rental = _context.Rentals.FirstOrDefault(r => r.RentalId == rentalId);

            if (rental == null)
            {
                return NotFound("Rental not found");
            }

            rental.Status = "Canceled"; 
            _context.SaveChanges();

            return Ok(new { message = "Rental has been canceled" });
        }
    }
}
