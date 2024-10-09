using Sale.Domain.Entities.Base;
using Sale.Domain.Entities.Customers;
using Sale.Domain.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sale.Domain.Entities.Orders
{
    public class Order:BaseEntity<long>
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
       
    }
}
