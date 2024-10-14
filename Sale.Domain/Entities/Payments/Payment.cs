using Sale.Domain.Entities.Orders;
using Sale.Domain.Enumerations;

namespace Sale.Domain.Entities.Payments
{
    public class Payment
    {
        public int Id { get; set; }
        public PaymentType Type { get; set; }
        public Order Order { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}
