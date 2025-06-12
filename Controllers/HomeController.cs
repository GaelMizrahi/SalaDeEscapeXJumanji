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
        juego juego = new juego();
        HttpContext.Session.SetString("juego", Objeto.ObjectToString(juego));
        return View();
    }
    public IActionResult sala1()
    {

        juego juego = Objeto.StringToObject<juego>(HttpContext.Session.GetString("jugar"));
        return View("sala1");
    }
    public IActionResult tutorial()
    {
        return View("tutorial");
    }
    public IActionResult creadores(){
        return View("creadores");
    }
    public IActionResult comparar(string codigo)
    {
        juego juego = Objeto.StringToObject<juego>(HttpContext.Session.GetString("jugar"));
        ViewBag.ganar = juego.compararRespuesta(codigo.ToLower(), juego.sala);
        if (ViewBag.ganar) ViewBag.sala = "sala" + juego.sala + 1;
        else ViewBag.sala = "index";
        return View(ViewBag.sala);
    }
    public IActionResult pistas()
    {
        juego juego = Objeto.StringToObject<juego>(HttpContext.Session.GetString("jugar"));
        ViewBag.sala = "pista" + juego.sala;
        return (ViewBag.sala);
    }

}
