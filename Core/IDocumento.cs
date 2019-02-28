using OpenInvoicePeru.Comun.Dto.Contratos;

namespace SigcomtElectronico.Models.Core
{
    public interface IDocumento
    {
        string CertificadoDigital { get; set; }
        string PasswordCertificado { get; set; }
        string UsuarioSol { get; set; }
        string ClaveSol { get; set; }
        int Ambiente { get; set; }

        string NroDocumento { get; set; }
        string IdDocumento { get; set; }
        string TipoDocumento { get; set; }
        string UblVersion { get; set; }
    }
}