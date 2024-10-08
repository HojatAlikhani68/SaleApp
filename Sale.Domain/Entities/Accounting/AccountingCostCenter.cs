using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.Accounting
{
    public class AccountingCostCenter: BaseEntity<short>
    {
        public string Name { get; set; }
        public string Notes { get; set; }
        public decimal Amount { get; set; }
        public bool IsActive { get; set; }
    }

}
