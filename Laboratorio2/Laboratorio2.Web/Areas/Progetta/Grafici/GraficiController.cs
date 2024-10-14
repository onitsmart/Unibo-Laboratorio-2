using Microsoft.AspNetCore.Mvc;
using System;

namespace Laboratorio2.Web.Areas.Progetta.Grafici
{
    // ES4: Raggiungere queste actions
    [Area("Progetta")]
    public partial class GraficiController : Controller
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
    }
}
