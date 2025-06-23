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
        else ViewBag.sala = "index";

        HttpContext.Session.SetString("juego", Objeto.ObjectToString(juego));
        return View(ViewBag.sala);
    }

   public IActionResult compararC(char letra)
    {
        juego juego = Objeto.StringToObject<juego>(HttpContext.Session.GetString("juego"));
        ViewBag.resp = juego.respuestas[5];
        ViewBag.letras.Add(letra);
        if (ViewBag.Letras.Count() == ViewBag.resp.Count())
        {
            if (ViewBag.letras == ViewBag.resp())   ViewBag.sala = "sala6";
            else ViewBag.sala = "index";
        } else ViewBag.sala = "sala5";

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
