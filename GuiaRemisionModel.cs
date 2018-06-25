using OpenInvoicePeru.Comun.Dto.Contratos;
using OpenInvoicePeru.Comun.Dto.Modelos;
using SigcomtElectronico.Models.Core;

namespace SigcomtElectronico.Models
{
    public class GuiaRemisionModel : IDocumento
    {
        public string CertificadoDigital { get; set; }
        public string PasswordCertificado { get; set; }
        public string UsuarioSol { get; set; }
        public string ClaveSol { get; set; }
        public int Ambiente { get; set; }

        public string NroDocumento { get; set; }
        public string IdDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string Correos { get; set; }

        public GuiaRemision DocumentoElectronico { get; set; }

        public GuiaRemisionModel()
        {
            DocumentoElectronico = new GuiaRemision();
        }
    }
}