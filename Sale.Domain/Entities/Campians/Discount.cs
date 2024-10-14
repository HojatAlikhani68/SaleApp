using Sale.Domain.Entities.Orders;
using Sale.Domain.Enumerations;


namespace Sale.Domain.Entities.Discounts
{
    public class Discount : Campain
    {

        public CampainType Type { get; set; }
        public decimal Price { get; set; }
        public float Percentage { get; set; }
        public string Calculation { get; set; }
        public ICollection<Order> Orders { get; set; } = [];

    }
}