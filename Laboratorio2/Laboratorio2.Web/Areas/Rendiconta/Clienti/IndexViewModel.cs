using System;
using System.Collections.Generic;
using System.Linq;

namespace Laboratorio2.Web.Areas.Rendiconta.Clienti
{
    public class IndexViewModel
    {
        public IEnumerable<ClienteInElencoViewModel> Clienti { get; set; }

        public IndexViewModel()
        {
            Clienti = Array.Empty<ClienteInElencoViewModel>();
        }

        // DATI INVENTATI IN QUANTO NON C'E' UN DB
        public void SetClienti(IEnumerable<ClienteModel> clienti)
        {
            this.Clienti = clienti.Select(x => new ClienteInElencoViewModel
            {
                Id = x.Id,
                RagioneSociale = x.RagioneSociale
            });
        }
    }

    public class ClienteInElencoViewModel
    {
        public Guid Id { get; set; }
        public string RagioneSociale { get; set; }
    }
}
