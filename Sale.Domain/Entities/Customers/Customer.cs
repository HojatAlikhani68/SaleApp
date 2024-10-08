using Sale.Domain.Entities.Base;
using Sale.Domain.Entities.Geographics;
using Sale.Domain.Enumerations;

namespace Sale.Domain.Entities.Customers
{
    public class Customer:BaseImportantEntity<int>
    {
        public Guid Guid { get; set; }
        public CustomerStatus Status { get; set; }
        public CustomerType Type  { get; set; }
        public required string Name { get; set; }
        public string SubName { get; set; }
        public DateOnly DateBirth { get; set; }
        public string Mobile { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public DateTime JoinDate { get; set; }
        public bool IsLegal { get; set; } 
        public string? Image { get; set; }
        public string? Notes { get; set; }
        public bool IsVIP { get; set; }
        public CustomerGroup PhoneNumber { get; set; }
        public List<Address> Address { get; set; } = [];

    }

}
