using Sale.Domain.Entities.Base;
using Sale.Domain.Entities.Discounts;
using Sale.Domain.Entities.Promotions;
using Sale.Domain.Enumerations;
using SaleApp.Shared;

namespace Sale.Domain.Entities.Products
{
    public class Product : BaseImportantEntity<int>
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public double Quantity { get; set; }
        public decimal UnitPrice { get; set; } 
        public decimal Price { get; set; }
        public IEnumerable<Discount> Discounts { get; set; } = [];
        public IEnumerable<Promotion> Pomotions { get; set; } = [];
        public decimal Tax { get; set; }
        public Size3D Size { get; set; }
        public string Image {  get; set; }
        public ProductStatus Status { get; set; }

    }

}
