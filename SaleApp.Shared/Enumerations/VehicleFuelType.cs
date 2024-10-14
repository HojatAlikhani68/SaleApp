namespace Sale.Domain.Enumerations
{
    public enum VehicleFuelType : byte
    {
        Unknown = 0,
        Petrol =1,
        DieselFuel = 2,
        CngGas = 3,
        Electric = 4,
    }
    public enum PaymentType:byte
    {
        Unknown,
        Cach =1,
        Pos =2,
        Cheque =3,
        Recipt =4,
        Barter =5,
    }
}
