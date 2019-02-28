using OpenInvoicePeru.Comun.Dto.Modelos;
using System.Collections.Generic;

namespace SigcomtElectronico.Models
{
    public class DocumentoElectronicoSigcomt : DocumentoElectronico
    {
        public string CondicionPago { get; set; }
        public string Match { get; set; }

        public new List<DetalleDocumentoElectronicoSigcomt> Items { get; set; }
    }
}
