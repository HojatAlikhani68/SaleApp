using Sale.Domain.Entities.Accounting;
using Sale.Domain.Entities.Base;
using Sale.Domain.Entities.Invoices;
using Sale.Domain.Entities.Orders;
using Sale.Domain.Entities.Products;

namespace Sale.Domain.Entities.Warehouses
{
    public class WarehouseDocumentItem : BaseImportantEntity<long>
    {
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal Unit { get; set; }
        public AccountingCostCenter CostCenter { get; set; }
        public OrderItem OrderItem { get; set; }
        public InvoiceItem InvoiceItem { get; set; }
        public WarehouseDocument WarehouseDocument { get; set; }

    }
}
