using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.Promotions
{
    public class Promotion:BaseImportantEntity<int>
    {
        public required string Title { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Description { get; set; }
        public double Quantity { get; set; }
    }
}
