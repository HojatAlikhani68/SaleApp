using Sale.Domain.Entities.Base;
using Sale.Domain.Entities.Geographics;
using Sale.Domain.Entities.Products;

namespace Sale.Domain.Entities.Suppliers
{
    public class Supplier:BaseImportantEntity<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string WebSiteUrl { get; set; }

        public List<Address> Addresses { get; set; }
        public List<Product> Products { get; set; } = [];

    }
}
