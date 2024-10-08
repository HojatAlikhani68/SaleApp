namespace Sale.Domain.Enumerations
{
    public enum CustomerStatus : byte
    {
        Unknown,
        Active = 1,
        InActive = 2,
        Blocked = 3,
        Deleted = 4,
    }
}
