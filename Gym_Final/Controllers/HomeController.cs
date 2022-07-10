using Gym_Final.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Gym_Final.Controllers
{
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

        public IActionResult Tienda()
        {
            return View();
        }

        public IActionResult RegistroPrincipal()
        {
            return View();
        }

        public IActionResult RegistroCliente()
        {
            return View();
        }

        public IActionResult InicioSesionCliente()
        {
            return View();
        }

        public IActionResult RegistroNuevoCliente()
        {
            return View();
        }
        public IActionResult SesionIniciadaCliente()
        {
            return View();
        }

        public IActionResult InicioSesionPersonal()
        {
            return View();
        }

        public IActionResult PlataformaAdministrativa()
        {
            return View();
        }

        public IActionResult MenuRegistros()
        {
            return View();
        }

        public IActionResult MenuReportes()
        {
            return View();
        }

        public IActionResult InscripActividadGrupal()
        {
            return View();
        }

        public IActionResult MarcarAsistencia()
        {
            return View();
        }

        public IActionResult SelecActividadGrupal()
        {
            return View();
        }
        public IActionResult PlataformaCliente()
        {
            return View();
        }
        public IActionResult ReporteActivGrupal()
        {
            return View();
        }
        public IActionResult ReporteArticDepor()
        {
            return View();
        }
        public IActionResult ReporteAsistencias()
        {
            return View();
        }
        public IActionResult RegistroActivGrupal()
        {
            return View();
        }
        public IActionResult RegistroArticDepor()
        {
            return View();
        }
        public IActionResult RegistroMembresias()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}