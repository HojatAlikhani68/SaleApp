using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.Customers
{
    public class CustomerGroup:BaseEntity<short>
    {
        public short ParentId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public List<Customer> Customers { get; set; } = [];
    }

}
