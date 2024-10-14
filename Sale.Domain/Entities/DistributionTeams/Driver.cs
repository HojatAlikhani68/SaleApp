using Sale.Domain.Entities.Base;
using Sale.Domain.Entities.Contracts;
using Sale.Domain.Enumerations;

namespace Sale.Domain.Entities.DistributionTeams
{
    public class Driver : DistributionTeam
    {
        public DriverType Type { get; set; }
        public string CertificateNo { get; set; }
        public DriverCertificateType CertificateType { get; set; }
        public DateOnly CertificateExpirDate { get; set; }
        public bool HasPhysicalDisability { get; set; }
    }
}
