using Sale.Domain.Entities.Base;
using Sale.Domain.Entities.Discounts;
using Sale.Domain.Entities.Suppliers;
using Sale.Domain.Enumerations;
using SaleApp.Shared.Structures;

namespace Sale.Domain.Entities.Products
{
    public class Product : BaseEntity<int>
    {
        public required string Name { get; set; }
        public decimal Tax { get; set; }
        public Size3D Size { get; set; }
        public string Image { get; set; }
        public sbyte Temperature { get; set; }
        public ushort UntilExpiration { get; set; }
        public DateOnly ProductionDate { get; set; }
        public ProductStatus Status { get; set; }

        public Supplier Supplier { get; set; }
        public ProductCategory ProductCategory { get; set; }

        public ICollection<ProductUnit> Units { get; set; } = [];
        public ICollection<Reward> Promotions { get; set; } = [];
        public ICollection<Discount> Discounts { get; set; } = [];
    }

}
