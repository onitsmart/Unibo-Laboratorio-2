using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio2.Web.Areas.Rendiconta.Clienti
{
    [Area("Rendiconta")]
    public partial class ClientiController : Controller
    {
        private IEnumerable<ClienteModel> _clienti = new List<ClienteModel>
            {
                new ClienteModel
                {
                    Id = Guid.Parse("365a0a52-4d73-4b1a-9a90-cae9cf69d4e5"),
                    RagioneSociale = "Cliente 1",
                    CapitaleSociale = 1000
                },
                new ClienteModel
                {
                    Id = Guid.Parse("3db4e547-9b10-4971-8580-155239615c2a"),
                    RagioneSociale = "Cliente 2",
                    CapitaleSociale = 2000
                },
                new ClienteModel
                {
                    Id = Guid.Parse("0a749c6c-0b87-481a-8ac2-03bc4f202449"),
                    RagioneSociale = "Cliente 3",
                    CapitaleSociale = 3000
                }
            };

        [HttpGet]
        public async virtual Task<IActionResult> Index(IndexViewModel model)
        {
            model.SetClienti(_clienti);

            return View(model);
        }

        [HttpGet]
        public async virtual Task<IActionResult> Edit(Guid idCliente)
        {
            var model = new EditViewModel();

            var cliente = _clienti.Where(x => x.Id == idCliente).FirstOrDefault();
            model.SetCliente(cliente);

            return View(model);
        }

        [HttpPost]
        public async virtual Task<IActionResult> Edit(EditViewModel model)
        {
            // Salvo tutti i dati....
            // Dati salvati

            return RedirectToAction(Actions.Edit(model.Id));
        }
    }
}
