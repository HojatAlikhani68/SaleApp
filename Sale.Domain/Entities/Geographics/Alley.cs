namespace Sale.Domain.Entities.Geographics
{
    public class Alley : BaseGeographic
    {
        public string SecondaryName { get; set; }
        public ICollection<Address> Addresses { get; set; } = [];
        public ICollection<Street> Streets { get; set; } = [];
    }
}
