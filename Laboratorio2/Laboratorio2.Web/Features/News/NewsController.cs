using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Laboratorio2.Web.Features.News
{
    public partial class NewsController : Controller
    {
        private readonly ILogger<NewsController> _logger;

        public NewsController(ILogger<NewsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public virtual IActionResult Detail(int anno, int mese, int giorno, string slug)
        {
            // ES5: Verificare di arrivare in questa action con tutti i parametri valorizzati

            var model = new NewsDetailViewModel
            {
                Anno = anno,
                Mese = mese,
                Giorno = giorno,
                Slug = slug
            };

            return View(model);
        }
    }
}