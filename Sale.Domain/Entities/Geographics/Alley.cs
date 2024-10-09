namespace Sale.Domain.Entities.Geographics
{
    public class Alley : BaseGeographic
    {
        public string SecondaryName { get; set; }
        public List<Address> Addresses { get; set; } = [];
        public List<Street> Streets { get; set; } = [];
    }
}
