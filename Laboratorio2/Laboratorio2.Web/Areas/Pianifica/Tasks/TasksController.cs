using Microsoft.AspNetCore.Mvc;
using System;

namespace Laboratorio2.Web.Areas.Pianifica.Tasks
{
    // ES1.1: CONTROLLER TASKS INSERITO NELL'AREA PIANIFICA, METTERE BREAKPOINT NELLA RIGA 14

    [Area("Pianifica")]
    public class TasksController : Controller
    {
        [HttpGet]
        public async System.Threading.Tasks.Task<IActionResult> Task(Guid id)
        {
            var test = "pluto";

            return View();
        }
    }
}
