using SaleApp.Shared;

namespace Sale.Domain.Entities.Geographics
{
    public class Region : BaseGeographic
    {
        public ICollection<GeoPoint> Points  { get; set; } = [];
        public State State { get; set; }
        public ICollection<Area> Areas { get; set; } = [];
    }
}
