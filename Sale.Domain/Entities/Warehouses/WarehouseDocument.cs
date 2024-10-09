using Sale.Domain.Entities.Base;
using Sale.Domain.Entities.Customers;
using Sale.Domain.Enumerations;
namespace Sale.Domain.Entities.Warehouses
{
    public class WarehouseDocument:BaseImportantEntity<long>
    {
        public WarehouseDocumentType Type { get; set; }
        public WarehouseDocumentTypeCause Cause { get; set; }
        public Warehouse Warehouse { get; set; }
        public Customer Customer {  get; set; }
        public bool IsWastage { get; set; }
        public ICollection<WarehouseDocumentItem> WarehouseDocumentItems { get; set; } = [];
    }
}
