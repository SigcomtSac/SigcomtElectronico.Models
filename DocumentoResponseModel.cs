using OpenInvoicePeru.Comun.Dto.Intercambio;

namespace SigcomtElectronico.Models
{
    public class DocumentoResponseModel : EnviarDocumentoResponse
    {
        public string TramaDocumentoXmlFirmado { get; set; }
    }
}