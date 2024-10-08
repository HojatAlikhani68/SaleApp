using SaleApp.Shared;

namespace Sale.Domain.Entities.Geographics
{
    public class Street : BaseGeographic
    {
        public string SecondaryName { get; set; }
        public float Width { get; set; }
        public List<Area> Areas { get; set; } = [];
        public List<Alley> Alleys { get; set; } = [];
    }
}
