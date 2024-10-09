using Sale.Domain.Entities.Base;
using Sale.Domain.Entities.Products;

namespace Sale.Domain.Entities.Orders
{
    public class OrderDetail: BaseEntity<long>
    {
        public int OrderDetailId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        // کلید خارجی به سفارش
        public int OrderId { get; set; }
        public Order Order { get; set; }

        // کلید خارجی به محصول (Product)
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
