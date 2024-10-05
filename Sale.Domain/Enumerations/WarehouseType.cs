namespace Sale.Domain.Enumerations
{
    public enum WarehouseType:byte
    {
        Unknown,
        Primary = 1,
        SafeReturn = 2,
        Wastages = 3,
        Ambulant = 4,
        Secondary = 5,
        Equipment = 6,
        Temporary = 7,
    }
}
