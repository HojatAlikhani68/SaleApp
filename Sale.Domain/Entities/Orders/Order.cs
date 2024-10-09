using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.Orders
{
    public class Order:BaseImportantEntity<int>
    {
        public Guid Guid { get; set; } = Guid.NewGuid(); 
        public IEnumerable<OrderItem> OrderItems { get; set; } = [];
    }
}
