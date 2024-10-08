using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.Accounting
{
    public class AccountingGroupLedger : BaseImportantEntity<byte>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public List<AccountingGeneralLedger> GeneralLedgers { get; set; } = [];
    }

}
