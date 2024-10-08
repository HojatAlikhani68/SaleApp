using Sale.Domain.Entities.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Sale.Domain.Entities.Products
{
    public class ProductCategory:BaseEntity<int>
    {
        public required string Name { get; set; }
        public string Notes { get; set; }
        public int ParentId { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<ProductCategory> ProductCategories { get; set; } = [];
        public IEnumerable<Product> Products { get; set; } = [];
    }

}
