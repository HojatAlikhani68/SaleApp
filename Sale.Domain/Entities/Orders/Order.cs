using Sale.Domain.Entities.Base;
using Sale.Domain.Entities.Customers;
using Sale.Domain.Entities.Discounts;
using Sale.Domain.Entities.Geographics;
using Sale.Domain.Entities.Payments;
using Sale.Domain.Entities.Products;
using Sale.Domain.Entities.Sellers;
using Sale.Domain.Enumerations;

namespace Sale.Domain.Entities.Orders
{
    public class Order : BaseEntity<long>
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
        public long CustomerId { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public DateTime? ShippingDate { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public decimal? CustomDiscount { get; set; } = 0;
        public string PaymentMethod { get; set; }
        public decimal TotalAmount { get; private set; }
        public decimal FinalAmount { get; private set; }
        public int OrderItemsCount { get; set; }

        public Address ShippingAddress { get; set; }
        public Customer Customer { get; set; }
        public ProductPrice Price { get; set; }
        public Seller Seller { get; set; }

        public ICollection<Payment> Payments { get; set; } = [];
        public ICollection<Reward> Promotions { get; set; } = [];
        public ICollection<Discount> Discount { get; set; } = [];
        public ICollection<OrderItem> OrderItems { get; set; } = [];

    }
}
