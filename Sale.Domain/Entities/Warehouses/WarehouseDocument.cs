using Sale.Domain.Entities.Base;
using Sale.Domain.Enumerations;

namespace Sale.Domain.Entities.Warehouses
{
    public class WarehouseDocument:BaseImportantEntity<int>
    {
        public WarehouseDocumentType Type { get; set; }
        public WarehouseDocumentTypeCause Cause { get; set; }
        public Warehouse Warehouse { get; set; }
        public string Customer {  get; set; }
        public IEnumerable<WarehouseDocumentItem> WarehouseDocumentItems { get; set; } = [];
    }
}
