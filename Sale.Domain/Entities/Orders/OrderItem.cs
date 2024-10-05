using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.Orders
{
    public class OrderItem:BaseEntity<long>
    {
        public Order Order { get; set; }
    }
}
