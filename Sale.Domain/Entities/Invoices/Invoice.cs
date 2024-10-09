using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.Invoices
{
    public class Invoice: BaseImportantEntity<long>
    {

        public ICollection<InvoiceItem> InvoiceItem { get; set; } = [];
    }
}
