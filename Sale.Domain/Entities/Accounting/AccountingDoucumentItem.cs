using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.Accounting
{
    public class AccountingDoucumentItem: BaseImportantEntity<long>
    {
        public int Order { get; set; }        
        public AcountingDetailed Detailed { get; set; }
        public decimal Debt { get; set; }
        public decimal Credit { get; set; }
    }

}
