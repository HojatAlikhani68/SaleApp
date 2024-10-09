namespace Sale.Domain.Enumerations
{
    public enum AccountingDocumentType : byte
    {
        Unknown,
        Normal = 1,
        Auto = 2,
        Daily = 3,
        Opening = 4,
        Closing = 5,
        Addition = 6,
        Deduction = 7,
    }
}
