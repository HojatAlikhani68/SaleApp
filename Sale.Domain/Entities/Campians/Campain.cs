using Sale.Domain.Entities.Base;
using Sale.Domain.Enumerations;


namespace Sale.Domain.Entities.Discounts
{
    public abstract class Campain: BaseEntity<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public CampainType Type { get; set; } 
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}