using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.Invoices
{
    public class Invoice: BaseImportantEntity<long>
    {

        public List<InvoiceItem> InvoiceItem { get; set; } = [];
    }
}
