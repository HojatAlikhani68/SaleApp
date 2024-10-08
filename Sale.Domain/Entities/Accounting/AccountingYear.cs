using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.Accounting
{
    public class AccountingYear:BaseEntity<short>
    {
        public string Name { get; set; }
        public  DateOnly FromDate { get; set; }
        public DateOnly ToDate { get; set; }
        public bool IsActive { get; set; }
    }

}
