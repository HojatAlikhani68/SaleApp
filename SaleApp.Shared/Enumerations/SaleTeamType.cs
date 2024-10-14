namespace Sale.Domain.Enumerations
{
    public enum SaleTeamType : byte
    {
        Unknown,
        Salesman = 1,
        Visitor = 2,
        NonAttendance = 3,
        PhoneVisitor = 4,
        Driver = 5,
        Supervisor = 6,
        DistrictManager = 7,
        SaleManager = 8,
    }
}
