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
        Canopy  = 8,
        Refrigerator = 9,
        Essential = 10,
    }
}
