
using Sale.Domain.Entities.Base;
using Sale.Domain.Enumerations;

namespace Sale.Domain.Entities.Employees
{
    public class EmployeeJob:BaseEntity<short>
    {
        public string Name { get; set; }
        public JobPosition Position { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }

    }
}
