using Sale.Domain.Entities.Products;
using Sale.Domain.Enumerations;

namespace Sale.Domain.Entities.Discounts
{
    public class Reward : Campain
    {
        public double Quantity { get; set; }
        public Product Product { get; set; }
        public CampainType Type { get; set; }
        public decimal Price { get; set; }
        public float Percentage { get; set; }
        public string Calculation { get; set; }
    }
}
