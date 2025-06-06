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

        ViewBag.juego = Objeto.StringToObject<juego>(HttpContext.Session.GetString("jugar"));
        return View("sala1");
    }
    public IActionResult comparar(string codigo)
    {
        ViewBag.juego = Objeto.StringToObject<juego>(HttpContext.Session.GetString("jugar"));
        if (ViewBag.juego.respuestas[ViewBag.juego.sala] == codigo)
        {
          
        }
    }
}
public IActionResult sala2()
{
    ViewBag.jugar = Objeto.StringToObject<juego>(HttpContext.Session.GetString("jugar"));
    return View("sala2");
}
public IActionResult sala3()
{
    ViewBag.jugar = Objeto.StringToObject<juego>(HttpContext.Session.GetString("jugar"));
    return View("sala3");
}
public IActionResult sala4()
{
    ViewBag.jugar = Objeto.StringToObject<juego>(HttpContext.Session.GetString("jugar"));
    return View("sala4");
}
public IActionResult creadores()
{
    return View("creadores");
}
public IActionResult tutorial()
{
    return View("tutorial");
}
public IActionResult prejugar()
{
    return View("prejugar");
}
public class CuentaController : Controller
{
    [HttpPost]
    public ActionResult Login(string usuario, string contrasena)
    {
        // Aquí podrías validar usuario y contraseña si quisieras.

        ViewBag.Usuario = usuario;
        return View("sala1");
    }

}
    }
