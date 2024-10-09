using Sale.Domain.Entities.Base;
using Sale.Domain.Entities.Products;

namespace Sale.Domain.Entities.Orders
{
    public class OrderItem : BaseEntity<long>
    {
        public long ProductId { get; set; } 
        public Product Product { get; set; } 
        public ProductUnit Unit { get; set; } 
        public double Quantity { get; set; } 
        public decimal Price { get; set; } 
        public long OrderId { get; set; } 
        public Order Order { get; set; }
        public decimal DiscountAmount { get; set; } 
        public decimal FinalPrice => Price - DiscountAmount; 
    }
}
