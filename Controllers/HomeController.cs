using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TPSalaDeEscape_Busso_Mizrahi_Brukiew.Models;

namespace TPSalaDeEscape_Busso_Mizrahi_Brukiew.Controllers;

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
