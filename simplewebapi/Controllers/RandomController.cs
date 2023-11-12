using Microsoft.AspNetCore.Mvc;
using auth_db;

namespace simplewebapi.Controllers;

[ApiController]
[Route("")]
public class RandomController : Controller
{
    private readonly ILogger<RandomController> _logger;
    private readonly AuthDatabaseContext _context;

    public RandomController(ILogger<RandomController> logger, AuthDatabaseContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public IActionResult HomePage()
    {
        _logger.LogInformation("Home page hit");

        var rng = new Random();
        var randomNumber = rng.Next(1, 100);

        // create the user
        var newUser = new AuthUser
        {
            firstName = "testuser",
            lastName = $"testuser {randomNumber}",
            email = $"fakeemail{randomNumber}@gmail.com",
            dateOfBirth = new DateTime(1990, 1, 1, 0, 0, 0, DateTimeKind.Utc),
        };

        _context.AuthUsers.Add(newUser);
        _context.SaveChanges();

        return View("Home", newUser);
    }
}