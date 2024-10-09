using SaleApp.Shared;

namespace Sale.Domain.Entities.Geographics
{
    public class Area : BaseGeographic
    {
        public ICollection<GeoPoint> Points { get; set; }
        public ICollection<Street> Streets { get; set; }
        public Region Region { get; set; }        
    }
}
