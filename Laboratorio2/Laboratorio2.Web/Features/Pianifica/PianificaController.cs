using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Laboratorio2.Web.Features.Tasks
{
    public class PianificaController : Controller
    {
        public async Task<IActionResult> Tasks(string id)
        {
            var test = "a";

            return View();
        }
    }
}
