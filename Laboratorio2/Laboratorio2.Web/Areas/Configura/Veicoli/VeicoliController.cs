using Microsoft.AspNetCore.Mvc;
using System;

namespace Laboratorio2.Web.Areas.Configura.Veicoli
{
    // ES4: Raggiungere queste actions
    [Area("Configura")]
    public partial class VeicoliController : Controller
    {
        [HttpGet]
        public async virtual System.Threading.Tasks.Task<IActionResult> Index()
        {
            var test = "pluto";

            return View();
        }

        [HttpGet]
        public async virtual System.Threading.Tasks.Task<IActionResult> Edit(Guid id)
        {
            var test = "pluto";

            return View(id);
        }

        [HttpGet]
        public async virtual System.Threading.Tasks.Task<IActionResult> CheckPlate(string plateNumber)
        {
            var test = "pluto";

            return View(plateNumber);
        }
    }
}
