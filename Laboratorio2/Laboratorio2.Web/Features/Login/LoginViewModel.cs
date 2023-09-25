using System.ComponentModel.DataAnnotations;

namespace Laboratorio2.Web.Features.Login
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [Display(Name ="Password")]
        public string Password { get; set; }
    }
}
