using Sale.Domain.Entities.Base;
using Sale.Domain.Entities.Employees;
using Sale.Domain.Enumerations;

namespace Sale.Domain.Entities.Sellers
{
    public class Seller : BaseEntity<object>
    {
        public Employee Employee { get; set; }
        public SellerType Type { get; set; }
        public decimal CreditAmount { get; set; }
        public bool IsLock { get; set; }
    }
}
