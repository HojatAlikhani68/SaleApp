using System.ComponentModel;

namespace Sale.Domain.Enumerations
{
    public enum OrderStatus : byte
    {
        UnKnown,
        [Description("در انتظار")]
        Pending = 1,
        [Description("تایید شده")]
        Confirmed = 2,  
        [Description("ارسال شده")]
        Shipped = 3, 
        [Description("تحویل داده شده")]
        Delivered = 4,  
        [Description("لغو شده")]
        Cancelled = 5,  
        [Description("مرجوع شده")]
        Returned = 6,

        
    }
}
