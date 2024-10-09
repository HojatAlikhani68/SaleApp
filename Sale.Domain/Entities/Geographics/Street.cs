using SaleApp.Shared;

namespace Sale.Domain.Entities.Geographics
{
    public class Street : BaseGeographic
    {
        public string SecondaryName { get; set; }
        public float Width { get; set; }
        public ICollection<Area> Areas { get; set; } = [];
        public ICollection<Alley> Alleys { get; set; } = [];
    }
}
