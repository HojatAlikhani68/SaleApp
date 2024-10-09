using System.ComponentModel;

namespace Sale.Domain.Enumerations
{
    public enum BroadcastStatus
    {
        [Description("نامعلوم")]
        Unknown,
        [Description("برنامه‌ریزی شده")]
        Scheduled = 1,  
        [Description("در حال پخش")]
        Broadcasting = 2, 
        [Description("پخش تکمیل شده")]
        Completed = 3, 
        [Description("لغو شده")]
        Cancelled = 4,  
        [Description("به تعویق افتاده")]
        Postponed = 5,    
        [Description("شکست خورده")]
        Failed = 6  
    }

}
