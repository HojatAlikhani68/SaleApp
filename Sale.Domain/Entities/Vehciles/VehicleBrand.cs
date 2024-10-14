using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.DistributionTeams
{
    public class VehicleBrand : BaseEntity<short>
    {
        public string Name { get; set; }
        public string Notes { get; set; }
    }
}
