namespace Sale.Domain.Enumerations
{
    public enum WarehouseDocumentTypeCause : byte
    {
        Unknown = 0,
        Buy = 1,
        Sell = 2,
        ReturnBuy = 3,
        ReturnSell = 4
    }
}
