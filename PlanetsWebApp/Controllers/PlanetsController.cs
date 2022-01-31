using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlanetsWebApp.Data;
using PlanetsWebApp.Models;

namespace PlanetsWebApp.Controllers
{
    public class PlanetsController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IPlanetService _planetService;

        public PlanetsController(IPlanetService planetService)
        {
            _planetService = planetService;
        }

        public async Task<IActionResult> Index (string? orderby)
        {
            var planets = await _planetService.GetAllPlanets();

            if(orderby != null)
            {
                ViewData["OrderBy"] = orderby;
            }

            return View(planets);
        }

        public async Task<JsonResult> Details(string name)
        {
            var planet = await _planetService.GetPlanetByName(name);

            return Json(planet);
        }
    }
}
