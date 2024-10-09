namespace Sale.Domain.Entities.Geographics
{
    public class State : BaseGeographic
    {
        public City City { get; set; }
        public ICollection<Region> Regions { get; set; } = [];
    }
}
