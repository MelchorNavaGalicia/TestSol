using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PruebaNetFrontEnd.Models;
using PruebaNetFrontEnd.Services;
using PruebaNetFrontEnd.Services.IServices;

namespace PruebaNetFrontEnd.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly IEmpleadoService _EmpleadosService;
		private readonly IAreaService _areasService;
		public EmpleadoController(IEmpleadoService EmpleadosService, IAreaService areasService)
        {
            _EmpleadosService = EmpleadosService;
            _areasService = areasService;
        }

        public async Task<ActionResult> EmpleadosIndex()
        {
            List<Empleado>? Empleados = new List<Empleado>();

            ResponseDto? response = await _EmpleadosService.GetEmpleadosAsync();

            if (response != null && response.IsSuccess == true)
            {
                string jsonEmpleados = Convert.ToString(response.Data);
                Empleados = JsonConvert.DeserializeObject<List<Empleado>>(jsonEmpleados);
            }

            return View(Empleados);
        }

        public async Task<ActionResult> EmpleadosCreate()
        {

            ResponseDto? areasResponse = await _areasService.GetAreasAsync();

			if (areasResponse != null && areasResponse.IsSuccess)
			{
				string jsonAreas = Convert.ToString(areasResponse.Data);
				List<Area> areas = JsonConvert.DeserializeObject<List<Area>>(jsonAreas);

                if (areas != null)
                {
                    ViewBag.Areas = areas;
                    Empleado nuevoEmpleado = new Empleado();
                    return View(nuevoEmpleado);
                }
                else
                {
                    return RedirectToAction("Error");
                }
            }
			else
			{
				return RedirectToAction("Error");
			}

        }

        [HttpPost]
        public async Task<ActionResult> EmpleadosCreate(Empleado model)
        {
            if (ModelState.IsValid)
            {
                ResponseDto? response = await _EmpleadosService.PostEmpleadoAsync(model);

                if (response != null && response.IsSuccess == true)
                {
                    return RedirectToAction(nameof(EmpleadosIndex));
                }

            }

            return View(model);
        }

        public async Task<ActionResult> EmpleadosDelete(int id)
        {
            ResponseDto? response = await _EmpleadosService.GetEmpleadoByIdAsync(id);

            if (response != null && response.IsSuccess == true)
            {
                string jsonEmpleado = Convert.ToString(response.Data);
                Empleado? model = JsonConvert.DeserializeObject<Empleado>(jsonEmpleado);

                return View(model);
            }


            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> EmpleadosDelete(Empleado model)
        {
            ResponseDto? response = await _EmpleadosService.DeleteEmpleadoByIdAsync(model.Id);

            if (response != null && response.IsSuccess == true)
            {
                return RedirectToAction(nameof(EmpleadosIndex));
            }

            return View(model);
        }

        public async Task<ActionResult> EmpleadosEdit(int id)
        {
            ResponseDto? response = await _EmpleadosService.GetEmpleadoByIdAsync(id);

            if (response != null && response.IsSuccess == true)
            {
                string jsonEmpleado = Convert.ToString(response.Data);
                Empleado? model = JsonConvert.DeserializeObject<Empleado>(jsonEmpleado);


				ResponseDto? areasResponse = await _areasService.GetAreasAsync();

				if (areasResponse != null && areasResponse.IsSuccess)
				{
					string jsonAreas = Convert.ToString(areasResponse.Data);
					List<Area> areas = JsonConvert.DeserializeObject<List<Area>>(jsonAreas);

					if (areas != null)
					{
						ViewBag.Areas = areas;
					}
					else
					{
						return RedirectToAction("Error");
					}
				}

				return View(model);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> EmpleadosEdit(Empleado model)
        {
            if (ModelState.IsValid)
            {
                ResponseDto? response = await _EmpleadosService.PutEmpleadoAsync(model);

                if (response != null && response.IsSuccess == true)
                {
                    return RedirectToAction(nameof(EmpleadosIndex));
                }

            }
           

            return View(model);
        }
    }
}
