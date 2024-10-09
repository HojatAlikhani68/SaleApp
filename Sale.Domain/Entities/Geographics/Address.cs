using SaleApp.Shared;

namespace Sale.Domain.Entities.Geographics
{
    public class Address : BaseGeographic 
    {
        public short Floor { get; set; }
        public float Unit { get; set; }
        public float No { get; set; }
        public GeoPoint Location { get; set; }
        public string PostalCode { get; set; }
        public Street Street { get; set; }
        public Alley Alley { get; set; }
    }
}
