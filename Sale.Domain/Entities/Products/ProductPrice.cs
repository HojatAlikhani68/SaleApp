using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.Products
{
    public class ProductPrice 
    {
        public int Id { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public Product Product { get; set; }
        public ProductPricePermission PricePermission { get; set; }
    }

}
