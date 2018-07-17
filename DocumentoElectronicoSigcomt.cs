using OpenInvoicePeru.Comun.Dto.Modelos;
using System.Collections.Generic;

namespace SigcomtElectronico.Models
{
    public class DocumentoElectronicoSigcomt : DocumentoElectronico
    {
        public string OrderReference { get; set; }
        public string CondicionPago { get; set; }
        public string FechaVencimiento { get; set; }
        public string Match { get; set; }

        public new List<DetalleDocumentoElectronicoSigcomt> Items { get; set; }
    }
}
