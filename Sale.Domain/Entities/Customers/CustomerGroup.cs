using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.Customers
{
    public class CustomerGroup:BaseEntity<short>
    {
        public short ParentId { get; set; }
        public required string Name { get; set; }
        public string Notes { get; set; }
        public ICollection<Customer> Customers { get; set; } = [];
    }

}
