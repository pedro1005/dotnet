using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebbApp.Models;

namespace WebbApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["Environment"] = HttpContext.Items["Environment"] ?? "Unknown";
        return View();
    }

    public IActionResult Privacy()
    {
        ViewData["Environment"] = HttpContext.Items["Environment"] ?? "Unknown";
        return View();
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
