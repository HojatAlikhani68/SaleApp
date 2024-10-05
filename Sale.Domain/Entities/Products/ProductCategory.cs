using Sale.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale.Domain.Entities.Products
{
    public class ProductCategory:BaseEntity<int>
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public int ParentId { get; set; }
        public bool IsActive { get; set; }
        public IList<ProductCategory> ProductCategories { get; set; } = [];
    }
}
