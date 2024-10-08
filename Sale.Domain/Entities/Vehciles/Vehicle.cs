using Sale.Domain.Entities.Base;
using Sale.Domain.Enumerations;
using SaleApp.Shared;
using System.IO;

namespace Sale.Domain.Entities.Vehciles
{
    public class Vehicle : BaseEntity<short>
    {
        public string Name { get; set; }
        public VehicleType VehicleType { get; set; }
        public DateOnly ProductionDate { get; set; }
        public byte WheelQuntity { get; set; }
        public VehicleFuelType FuelType { get; set; }
        public VehicleBrand VehicleBrand { get; set; }
        public Size3D ChamberVolume { get; set; }
        /// <summary>
        /// Liter per 100Km
        /// </summary>
        public byte FuelConsumption { get; set; }
        public DriverType DriverType { get; set; }
        public DriverCertificateType CertificateType { get; set; }
        public DateOnly CasualtyInsuranceExpirDate { get; set; }
        public DateOnly? CollisionInsuranceExpirDate { get; set; }
        public byte Weight { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public List<Driver> Drivers { get; set; } = [];

    }
}
