using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.Accounting
{
    public class AccountingPayableLedger : BaseImportantEntity<short>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public AccountingGeneralLedger GeneralLedger { get; set; }
        public ICollection<AcountingDetailed> AcountingDetaileds { get; set; } = [];
    }

}
