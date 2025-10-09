using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp10_preguntadort.Models;

namespace tp10_preguntadort.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
