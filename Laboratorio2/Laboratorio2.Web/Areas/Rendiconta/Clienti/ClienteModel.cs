using System;

namespace Laboratorio2.Web.Areas.Rendiconta.Clienti
{
    public class ClienteModel
    {
        public Guid Id { get; set; }
        public string RagioneSociale { get; set; }
        public decimal CapitaleSociale { get; set; }
    }
}
