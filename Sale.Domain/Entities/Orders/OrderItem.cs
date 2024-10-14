using Sale.Domain.Entities.Base;
using Sale.Domain.Entities.Discounts;
using Sale.Domain.Entities.Products;

namespace Sale.Domain.Entities.Orders
{
    public class OrderItem : BaseEntity<long>
    {
        public Product Product { get; set; } 
        public int ProductId {  get; set; }
        public ProductUnit Unit { get; set; } 
        public short UnitId { get; set; }
        public double Quantity { get; set; } 
        public long OrderId { get; set; } 
        public Order Order { get; set; }
        public decimal CustomDiscount { get; set; } 
        public Discount Discount { get; set; }

    }
}
