using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.Products
{
    public class ProductPricePermission : BaseEntity<int>
    {
        public DateTime StartDate { get; set; }
        public DateTime ExpireDate { get; set; }

        public ICollection<ProductPrice> ProductPrices { get; set; }
    }


}
