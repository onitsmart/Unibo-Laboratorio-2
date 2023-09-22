using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace Laboratorio2.Web.Features.Home
{
    public partial class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppSettings _appSettings;

        // ES2.1: Injecting appSettings
        public HomeController(ILogger<HomeController> logger, IOptions<AppSettings> appSettings)
        {
            _logger = logger;
            _appSettings = appSettings.Value;
        }

        public virtual IActionResult Index()
        {
            return View();
        }

        public virtual IActionResult Privacy()
        {
            return View();
        }
    }
}