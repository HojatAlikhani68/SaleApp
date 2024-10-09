using Sale.Domain.Entities.Base;
using Sale.Domain.Entities.Customers;
using Sale.Domain.Entities.Discounts;
using Sale.Domain.Entities.Geographics;
using Sale.Domain.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sale.Domain.Entities.Orders
{
    public class Order:BaseEntity<long>
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
        public Customer Customer { get; set; }
        public long CustomerId { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending; 
        public DateTime OrderDate { get; set; } = DateTime.Now; 
        public DateTime? ShippedDate { get; set; } 
        public Address ShippingAddress { get; set; } 
        public DateTime EstimatedDeliveryDate { get; set; }
        public DateTime? DeliveredDate { get; set; } 
        public decimal? DiscountAmount { get; set; } // مبلغ تخفیف دستی (اختیاری)
        public string PaymentMethod { get; set; } 
        public decimal TotalAmount { get; private set; } 
        public decimal FinalAmount { get; private set; } 
        public int OrderItemsCount { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = [];
        public ICollection<Discount> Discount { get; set; } 
        public ICollection<object> Promotions { get; set; } = []; 
       
    }
}
