
using Sale.Domain.Entities.Base;
using Sale.Domain.Entities.Contracts;
using Sale.Domain.Entities.Geographics;
using Sale.Domain.Enumerations;

namespace Sale.Domain.Entities.Employees
{
    public class Employee:BaseEntity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AliasName { get; set; }
        public byte Age { get; set; }
        public PersonGender Gender { get; set; }
        public string NationalId { get; set; }
        public EmployeeJob Job { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string BackupPhone { get; set; }
        public Address HomeAddress { get; set; }
        public Contract Contract { get; set; }
    }
}
