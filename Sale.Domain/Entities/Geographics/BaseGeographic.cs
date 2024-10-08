using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.Geographics
{
    public abstract class BaseGeographic: BaseEntity<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
