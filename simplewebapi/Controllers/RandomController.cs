using Microsoft.AspNetCore.Mvc;

namespace simplewebapi.Controllers;

[ApiController]
[Route("")]
public class RandomController : Controller
{
    private readonly ILogger<RandomController> _logger;

    public RandomController(ILogger<RandomController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult HomePage()
    {
        return View("Home");
    }
    
}