using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PruebaNetFrontEnd.Models;
using PruebaNetFrontEnd.Services.IServices;

namespace PruebaNetFrontEnd.Controllers
{
    public class AreaController : Controller
    {
        private readonly IAreaService _areasService;

        public AreaController(IAreaService areasService)
        {
            _areasService = areasService;
        }

        public async Task<ActionResult> AreasIndex()
        {
            List<Area>? Areas = new List<Area>();

            ResponseDto? response = await _areasService.GetAreasAsync();

            if (response != null && response.IsSuccess == true)
            {
                string jsonAreas = Convert.ToString(response.Data);
                Areas = JsonConvert.DeserializeObject<List<Area>>(jsonAreas);

                return View(Areas);
            }
            else
            {
                return View();
            }

        }

        public async Task<ActionResult> AreasCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AreasCreate(Area model)
        {
            if (ModelState.IsValid)
            {
                ResponseDto? response = await _areasService.PostAreaAsync(model);

                if (response != null && response.IsSuccess == true)
                {
                    return RedirectToAction(nameof(AreasIndex));
                }

            }

            return View(model);
        }

        public async Task<ActionResult> AreasDelete(int id)
        {
            ResponseDto? response = await _areasService.GetAreaByIdAsync(id);

            if (response != null && response.IsSuccess == true)
            {
                string jsonArea = Convert.ToString(response.Data);
                Area? model = JsonConvert.DeserializeObject<Area>(jsonArea);

                return View(model);
            }


            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> AreasDelete(Area model)
        {
            ResponseDto? response = await _areasService.DeleteAreaByIdAsync(model.IdArea);

            if (response != null && response.IsSuccess == true)
            {
                return RedirectToAction(nameof(AreasIndex));
            }

            return View(model);
        }

        public async Task<ActionResult> AreasEdit(int id)
        {
            ResponseDto? response = await _areasService.GetAreaByIdAsync(id);

            if (response != null && response.IsSuccess == true)
            {
                string jsonArea = Convert.ToString(response.Data);
                Area? model = JsonConvert.DeserializeObject<Area>(jsonArea);

                return View(model);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> AreasEdit(Area model)
        {
            if (ModelState.IsValid)
            {
                ResponseDto? response = await _areasService.PutAreaAsync(model);

                if (response != null && response.IsSuccess == true)
                {
                    return RedirectToAction(nameof(AreasIndex));
                }

            }

            return View(model);
        }
    }
}
