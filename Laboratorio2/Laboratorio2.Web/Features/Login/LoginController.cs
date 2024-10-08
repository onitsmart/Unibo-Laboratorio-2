using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Laboratorio2.Web.Features.Login
{
    public partial class LoginController : Controller
    {
        private readonly AppSettings _appSettings;

        public LoginController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        [HttpGet]
        public virtual IActionResult Login()
        {
            return View();
        }

        // ESERCIZIO 2 E 2.1
        [HttpPost]
        public virtual IActionResult Login(string username, string password)
        {
            if (_appSettings.DisabilitaControlloPassword || (username.Equals("pippo@onit.it") && password.Equals("Test123")))
            {
                return RedirectToAction(MVC.Home.Index(username));
            }

            return View();
        }

        // ESERCIZIO 2.2 con ViewData
        [HttpGet]
        public virtual IActionResult LoginConViewData()
        {
            var model = new LoginViewModel();

            return View(model);
        }

        [HttpPost]
        public virtual IActionResult LoginConViewData(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_appSettings.DisabilitaControlloPassword || (model.Username.Equals("pippo@onit.it") && model.Password.Equals("Test123")))
                {
                    return RedirectToAction(MVC.Home.Index(model.Username));
                }
            }

            ViewData["Errore"] = "Username o password errate";

            return View(new LoginViewModel());
        }

        // ESERCIZIO 2.2 con TempData
        [HttpGet]
        public virtual IActionResult LoginConTempData()
        {
            var model = new LoginViewModel();

            return View(model);
        }

        [HttpPost]
        public virtual IActionResult LoginConTempData(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_appSettings.DisabilitaControlloPassword || (model.Username.Equals("pippo@onit.it") && model.Password.Equals("Test123")))
                {
                    return RedirectToAction(MVC.Home.Index(model.Username));
                }
            }

            TempData["Errore"] = "Username o password errate";

            return RedirectToAction(Actions.LoginConTempData());
        }
    }
}
