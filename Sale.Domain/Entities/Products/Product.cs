using Sale.Domain.Entities.Base;
using Sale.Domain.Entities.Discounts;
using Sale.Domain.Entities.Promotions;
using Sale.Domain.Entities.Suppliers;
using Sale.Domain.Enumerations;
using SaleApp.Shared;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Sale.Domain.Entities.Products
{
    public class Product : BaseImportantEntity<int>
    {
        public string Code { get; set; }
        public required string Name { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public double Quantity { get; set; }
        public decimal UnitPrice { get; set; } 
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public Size3D Size { get; set; }
        public string Image {  get; set; }
        public Supplier Supplier { get; set; }
        public IEnumerable<Promotion> Promotions { get; set; } = [];
        public IEnumerable<Discount> Discounts { get; set; } = [];
        public ProductStatus Status { get; set; }

    }

}
