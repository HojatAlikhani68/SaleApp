namespace Sale.Domain.Entities.Geographics
{
    public class State : BaseGeographic
    {
        public City City { get; set; }
        public List<Region> Regions { get; set; } = [];
    }
}
