using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CarRental.Data; // Ensure namespace is correct
using Microsoft.EntityFrameworkCore;
using CarRental.Models;

public class ContactController : Controller
{
    private readonly AppDbContext _context;

    public ContactController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> SendMessage(string name, string email, string phone, string message)
    {
        Console.WriteLine("🔍 Form submitted..."); // Debugging log

        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(message))
        {
            Console.WriteLine("❌ Missing required fields!");
            TempData["ErrorMessage"] = "Please fill out all required fields.";
            return RedirectToAction("Index", "Home");
        }

        var contactMessage = new ContactMessage
        {
            Name = name,
            Email = email,
            Phone = phone,
            Message = message
        };

        try
        {
            _context.ContactMessages.Add(contactMessage);
            await _context.SaveChangesAsync(); // ✅ Ensure async save

            Console.WriteLine("✅ Message saved to database!");
            TempData["SuccessMessage"] = "Your message has been saved!";
        }
        catch (DbUpdateConcurrencyException ex)
        {
            Console.WriteLine($"❌ Concurrency error: {ex.Message}");
            TempData["ErrorMessage"] = "A database error occurred. Please try again.";
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Error saving message: {ex.Message}");
            TempData["ErrorMessage"] = "An error occurred while saving your message.";
        }

        return RedirectToAction("Index", "Home");
    }
}
