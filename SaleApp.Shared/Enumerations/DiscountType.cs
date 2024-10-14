using System.ComponentModel;

namespace Sale.Domain.Enumerations
{
    public enum CampainType:short
    {
        [Description("نامشخص")]
        Unknown,
        [Description("درصدی")]
        Percentage = 1,
        [Description("نقدی")]
        Cash = 2,
        [Description("سطری")]
        Line = 3,
        [Description("تعدادی")]
        Quantity = 4,
        [Description("فصلی")]
        Seasonal = 5,
        [Description("مشتری")]
        Customer = 6,
        [Description("اولین خرید")]
        FirstPurchase = 7,
        [Description("زماندار")]
        Time = 8,
        [Description("دستی")]
        Custom = 9,
        [Description("کالا")]
        Product = 10,

    }
}
