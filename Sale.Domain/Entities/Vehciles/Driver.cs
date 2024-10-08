using Sale.Domain.Entities.Base;
using Sale.Domain.Entities.Contracts;
using Sale.Domain.Enumerations;

namespace Sale.Domain.Entities.Vehciles
{
    public class Driver : BaseEntity<int>
    {
        public DriverType Type { get; set; }
        public string Name { get; set; }
        public string NationalId { get; set; }
        public byte Age { get; set; }
        public PersonGenderType Gernder { get; set; }
        public string CertificateNo { get; set; }
        public DriverCertificateType CertificateType { get; set; }
        public DateOnly CertificateExpirDate { get; set; }
        public bool HasPhysicalDisability { get; set; }
        public Contract Contract { get; set; }
        public bool IsActive { get; set; }
    }
}
