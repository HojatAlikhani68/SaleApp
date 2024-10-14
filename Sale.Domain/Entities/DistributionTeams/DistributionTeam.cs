using Sale.Domain.Entities.Base;
using Sale.Domain.Entities.Employees;
using Sale.Domain.Enumerations;

namespace Sale.Domain.Entities.DistributionTeams
{
    public abstract class DistributionTeam : BaseEntity<object>
    {
        public Employee Employee { get; set; }
        public SaleTeamType Type { get; set; }
        public decimal CreditAmount { get; set; }
        public bool IsLock { get; set; }
    }
}
