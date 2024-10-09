﻿using Sale.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale.Domain.Entities.Invoices
{
    public class InvoiceItem:BaseImportantEntity<long>
    {
        public Invoice Invoice { get; set; }
    }
}
