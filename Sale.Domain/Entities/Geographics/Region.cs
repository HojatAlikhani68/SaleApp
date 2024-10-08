using SaleApp.Shared;

namespace Sale.Domain.Entities.Geographics
{
    public class Region : BaseGeographic
    {
        public List<GeoPoint> Points  { get; set; } = [];
        public State State { get; set; }
        public List<Area> Areas { get; set; } = [];
    }
}
