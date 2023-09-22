using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Laboratorio2.Web.Features.Tasks
{
    // ES1.1: CONTROLLER PIANIFICA, METTERE BREAKPOINT NELLA RIGA 14

    public class PianificaController : Controller
    {
        public async Task<IActionResult> Tasks(string id)
        {
            var test = "a";

            return View();
        }
    }
}
