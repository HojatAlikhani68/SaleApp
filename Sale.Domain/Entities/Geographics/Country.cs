namespace Sale.Domain.Entities.Geographics
{
    public class Country : BaseGeographic
    {
        public string NationalName { get; set; }
        public ICollection<City> Cities { get; set; } = [];
    }
}
