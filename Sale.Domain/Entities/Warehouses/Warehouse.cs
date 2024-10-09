using Sale.Domain.Entities.Base;
using Sale.Domain.Entities.Geographics;
using Sale.Domain.Enumerations;
using SaleApp.Shared.Structures;

namespace Sale.Domain.Entities.Warehouses
{
    public class Warehouse:BaseEntity<short>
    {
        public required string Name { get; set; }
        public WarehouseType Type { get; set; }
        public Size3D Size { get; set; }
        public bool CanSale { get; set; }
        public bool IsActive { get; set; }
        public bool IsLocked { get; set; }
        public sbyte Temperature { get; set; }
        public Address Address { get; set; }
    }
}
