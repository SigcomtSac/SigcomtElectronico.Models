using OpenInvoicePeru.Comun.Dto.Modelos;

namespace SigcomtElectronico.Models
{
    public class DocumentoElectronicoSigcomt : DocumentoElectronico
    {
        public string OrderReference { get; set; }
        public string CondicionPago { get; set; }
        public string FechaVencimiento { get; set; }
    }
}
