
using Sale.Application.Dtos;
using System.ComponentModel;
using System.Reflection;

namespace SaleApp.Shared.Extentions
{
    public static class EnumExtensions
    {        
        public static string GetEnumDescription(this Enum value)
        {
            FieldInfo field = value
                .GetType()
                .GetField(value.ToString());

            if (field != null)
            {
                DescriptionAttribute attribute =
                    Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;

                if (attribute != null)
                {
                    return attribute.Description;
                }
            }

            return value.ToString(); // اگر توضیحی وجود نداشته باشد، نام خود enum را برمی‌گرداند
        }
        public static List<EnumInfo> ToEnumInfoList<T>() where T : Enum
        {
            var enumType = typeof(T);
            var enumValues = Enum.GetValues(enumType);

            var enumInfoList = new List<EnumInfo>();

            foreach (var value in enumValues)
            {
                var fieldInfo = enumType.GetField(value.ToString());
                var descriptionAttribute = fieldInfo.GetCustomAttribute<DescriptionAttribute>();
                var description = descriptionAttribute != null ? descriptionAttribute.Description : string.Empty;

                enumInfoList.Add(new EnumInfo(
                    Id: Convert.ToInt32(value), // شناسه (ID) به عنوان مقدار عددی enum
                    Name: value.ToString(),      // نام (Name) مقدار enum
                    Description: description      // توضیحات (Description)
                ));
            }

            return enumInfoList;
        }
    }
}
