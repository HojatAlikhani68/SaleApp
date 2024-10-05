using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.Warehouses
{
    public class WarehouseDocumentItem : BaseImportantEntity<long>
    {
        public WarehouseDocument WarehouseDocument { get; set; }
    }
}
