using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.Products
{
    public class ProductUnit : BaseEntity<short> 
    {
        public short? ParentId { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public ProductUnit Parent { get; set; } 
        public ICollection<ProductUnit> Children { get; set; }
        public ICollection<Product> Products { get; set; } 
    }

}
