using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Laboratorio2.Web.Features.Tasks
{
    // ES1.1: CONTROLLER PIANIFICA, METTERE BREAKPOINT NELLA RIGA 13

    public partial class PianificaController : Controller
    {
        public async virtual Task<IActionResult> Tasks(string id)
        {
            var test = "a";

            return View();
        }
    }
}
