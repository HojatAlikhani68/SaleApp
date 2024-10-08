using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.Vehciles
{
    public class VehicleBrand : BaseEntity<short>
    {
        public string Name { get; set; }
        public string Notes { get; set; }
    }
}
