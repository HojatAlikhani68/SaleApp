﻿using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.Accounting
{
    public class AcountingDetailed : BaseImportantEntity<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public ICollection<AccountingPayableLedger> PayableLedgers { get; set; } = [];
    }

}
