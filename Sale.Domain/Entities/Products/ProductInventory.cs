using Sale.Domain.Entities.Base;
using Sale.Domain.Entities.Warehouses;

namespace Sale.Domain.Entities.Products
{
    public class ProductInventory : BaseEntity<long>
    {
        public Product Product { get; set; }
        public Warehouse Warehouse { get; set; }
        public ProductUnit ProductUnit { get; set; }
        public double Inventory {  get; set; }
        public bool IsLock { get; set; }
    }

}


