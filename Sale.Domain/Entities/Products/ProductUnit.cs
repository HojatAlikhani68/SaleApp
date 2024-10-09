using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.Products
{
    public class ProductUnit : BaseEntity<short> 
    {
        public short ParentId { get; set; }
        public string Name { get; set; }
        public double MainQuantity { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public Product Product { get; set; }
    }

}
