using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Laboratorio2.Web.Features.Login
{
    public partial class LoginController : Controller
    {
        [HttpGet]
        public virtual IActionResult Login()
        {
            var model = new LoginViewModel();

            return View(model);
        }

        [HttpPost]
        public virtual IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Username == "pippo@onit.it" && model.Password == "Test123")
                {
                    return RedirectToAction(MVC.Home.Index(model.Username));
                }
            }

            TempData["Errore"] = "Username o password errate";
 
            return RedirectToAction(Actions.Login());
        }
    }
}
