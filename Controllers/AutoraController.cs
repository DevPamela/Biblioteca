using Microsoft.AspNetCore.Mvc;

namespace BibliotecaMVC.Controllers
{
    public class AutoraController : Controller
    {
        public IActionResult Autora()
        {
            var listaDeAutoras = new Autora("Pamela").Model;
            return View(listaDeAutoras);
        }

        public string Welcome()
        {
            return "Boas vindas";
        }
    }
}
