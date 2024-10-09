namespace Sale.Domain.Enumerations
{
    public enum OrderStatus : byte
    {
        Unknown,
        Pending = 1,
        Confirmed = 2,
        Shipped = 3,
        Delivered = 4,
        Canceled = 5
    }
}
