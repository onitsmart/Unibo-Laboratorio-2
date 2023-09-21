using Microsoft.AspNetCore.Mvc;
using System;

namespace Laboratorio2.Web.Areas.Pianifica.Tasks
{
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
