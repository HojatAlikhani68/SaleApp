using SaleApp.Shared;

namespace Sale.Domain.Entities.Geographics
{
    public class Area : BaseGeographic
    {
        public List<GeoPoint> Points { get; set; }
        public List<Street> Streets { get; set; }
        public Region Region { get; set; }        
    }
}
