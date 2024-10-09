using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.Accounting
{
    public class AccountingGeneralLedger : BaseImportantEntity<short>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public AccountingGroupLedger GroupLedger { get; set; }
        public ICollection<AccountingPayableLedger> PayableLedgers { get; set; } = [];
    }

}
