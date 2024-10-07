using Microsoft.AspNetCore.Mvc;

namespace Laboratorio2.Web.Features.Login
{
    public partial class LoginController : Controller
    {
        [HttpGet]
        public virtual IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public virtual IActionResult Login(string username, string password)
        {
            if (username.Equals("pippo@onit.it") && password.Equals("Test123"))
            {
                return RedirectToAction(MVC.Home.Index(username));
            }

            return View();
        }

        [HttpGet]
        public virtual IActionResult Login2()
        {
            var model = new LoginViewModel();

            return View(model);
        }

        [HttpPost]
        public virtual IActionResult Login2(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Username == "pippo@onit.it" && model.Password == "Test123")
                {
                    return RedirectToAction(MVC.Home.Index(model.Username));
                }
            }

            ViewData["Errore"] = "Username o password errate";

            return View(new LoginViewModel());
        }

        [HttpGet]
        public virtual IActionResult Login3()
        {
            var model = new LoginViewModel();

            return View(model);
        }

        [HttpPost]
        public virtual IActionResult Login3(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Username == "pippo@onit.it" && model.Password == "Test123")
                {
                    return RedirectToAction(MVC.Home.Index(model.Username));
                }
            }

            TempData["Errore"] = "Username o password errate";

            return RedirectToAction(Actions.Login2());
        }
    }
}
