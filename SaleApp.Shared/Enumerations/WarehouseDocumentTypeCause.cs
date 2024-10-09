namespace Sale.Domain.Enumerations
{
    public enum WarehouseDocumentTypeCause : byte
    {
        Unknown = 0,
        Buy = 1,
        Sale = 2,
        ReturnBuy = 3,
        ReturnSale = 4
    }
}
