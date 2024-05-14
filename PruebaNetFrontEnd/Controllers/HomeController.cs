using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PruebaNetFrontEnd.Models;
using PruebaNetFrontEnd.Services.IServices;
using System.Diagnostics;

namespace PruebaNetFrontEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmpleadoService _empleadoService;

        public HomeController(ILogger<HomeController> logger , IEmpleadoService empleadoService)
        {
            _logger = logger;
            _empleadoService = empleadoService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            List<Empleado>? Empleado = new List<Empleado>();

            ResponseDto? response = await _empleadoService.GetEmpleadosAsync();

            if (response != null && response.IsSuccess == true)
            {
                string jsonEmpleado = Convert.ToString(response.Data);
                Empleado = JsonConvert.DeserializeObject<List<Empleado>>(jsonEmpleado);
            }

            return View(Empleado);
        }

        public IActionResult Privacy()
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
