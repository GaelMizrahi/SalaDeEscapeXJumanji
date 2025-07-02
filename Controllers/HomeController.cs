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
    public IActionResult RegresarSala()
    {
        juego juego = Objeto.StringToObject<juego>(HttpContext.Session.GetString("juego"));
        ViewBag.sala = "sala" + juego.sala;
        return View(ViewBag.sala);
    }

    public IActionResult sala1()
    {
        return View("sala1");
    }
    public IActionResult tutorial()
    {
        return View("tutorial");
    }
    public IActionResult creadores()
    {
        return View("creadores");
    }
    public IActionResult comparar(string codigo)
    {
        juego juego = Objeto.StringToObject<juego>(HttpContext.Session.GetString("juego"));
        ViewBag.ganar = juego.compararRespuesta(codigo.ToLower());
        if (ViewBag.ganar) ViewBag.sala = "sala" + juego.sala;
        else return RedirectToAction("Index");

        HttpContext.Session.SetString("juego", Objeto.ObjectToString(juego));
        return View(ViewBag.sala);
    }

   public IActionResult compararC(char Letra)
    {
        juego juego = Objeto.StringToObject<juego>(HttpContext.Session.GetString("juego"));
        bool ganar = juego.compararC(Letra);
        if (juego.letras.Count == 10 && ganar) ViewBag.sala = "sala6";
        else if (juego.letras.Count < 10 && ganar) ViewBag.sala = "sala5";
        else if (!ganar) return RedirectToAction("Index");
        HttpContext.Session.SetString("juego", Objeto.ObjectToString(juego));
        return View(ViewBag.sala);
    }
    public IActionResult pistas()
    {
        juego juego = Objeto.StringToObject<juego>(HttpContext.Session.GetString("juego"));
        ViewBag.sala = "pista" + juego.sala;
        ViewBag.pista = juego.pistas[juego.sala];
        return View(ViewBag.sala);
    }

}
