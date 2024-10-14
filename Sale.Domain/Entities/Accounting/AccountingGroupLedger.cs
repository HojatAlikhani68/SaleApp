using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.Accounting
{
    public class AccountingGroupLedger : BaseEntity<byte>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public ICollection<AccountingGeneralLedger> GeneralLedgers { get; set; } = [];
    }

}
