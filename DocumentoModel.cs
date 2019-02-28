using SigcomtElectronico.Models.Core;

namespace SigcomtElectronico.Models
{
    public class DocumentoModel : IDocumento
    {
        public string CertificadoDigital { get; set; }
        public string PasswordCertificado { get; set; }
        public string UsuarioSol { get; set; }
        public string ClaveSol { get; set; }
        public int Ambiente { get; set; }
        public string UblVersion { get; set; }

        public string NroDocumento { get; set; }
        public string IdDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string Correos { get; set; }

        public DocumentoElectronicoSigcomt DocumentoElectronico { get; set; }        

        public DocumentoModel()
        {
            DocumentoElectronico = new DocumentoElectronicoSigcomt();
        }
    }
}