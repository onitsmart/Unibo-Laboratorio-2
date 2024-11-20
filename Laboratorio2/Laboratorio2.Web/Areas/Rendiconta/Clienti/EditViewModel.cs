using System;

namespace Laboratorio2.Web.Areas.Rendiconta.Clienti
{
    public class EditViewModel
    {
        public Guid Id { get; set; }
        public string RagioneSociale { get; set; }
        public decimal CapitaleSociale { get; set; }

        public void SetCliente(ClienteModel cliente)
        {
            if (cliente != null)
            {
                Id = cliente.Id;
                RagioneSociale = cliente.RagioneSociale;
                CapitaleSociale = cliente.CapitaleSociale;
            }
        }
    }
}
