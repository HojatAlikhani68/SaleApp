namespace Sale.Domain.Entities.Geographics
{
    public class City : BaseGeographic
    {
        public Country Country { get; set; }
        public ICollection<Region> Regions { get; set; } = [];
    }
}
