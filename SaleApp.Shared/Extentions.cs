
namespace SaleApp.Shared
{
    public static class Extentions
    {
        public static int ToInt(this object value)
            => Convert.ToInt32(value);
        public static T ToType<T>(object value)
        {
            try
            {
                return (T)value;
            }
            catch 
            {
                return default;
            }
        }
    }
}
