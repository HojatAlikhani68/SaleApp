namespace SaleApp.Shared.Extentions
{
    public static class ConversionExtensions
    {
        public static int ToInt(this object value)
        { return Convert.ToInt32(value); }
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
        public static TDestination ConvertTo<TSource, TDestination>(this TSource source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source), "Source cannot be null");
            }

            var destination = Activator.CreateInstance<TDestination>();

            foreach (var sourceProperty in typeof(TSource).GetProperties())
            {
                var destinationProperty = typeof(TDestination).GetProperty(sourceProperty.Name);
                if (destinationProperty != null && destinationProperty.CanWrite)
                {
                    destinationProperty.SetValue(destination, sourceProperty.GetValue(source));
                }
            }

            return destination;
        }
        public static List<TDestination> ConvertToList<TSource, TDestination>(this IEnumerable<TSource> sourceList)
        {
            if (sourceList == null)
            {
                throw new ArgumentNullException(nameof(sourceList), "Source list cannot be null");
            }

            var destinationList = new List<TDestination>();

            foreach (var source in sourceList)
            {
                var destination = source.ConvertTo<TSource, TDestination>();
                destinationList.Add(destination);
            }

            return destinationList;
        }
        public static TDestination ConvertTo<TDestination>(this object source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source), "Source cannot be null");
            }

            var destination = Activator.CreateInstance<TDestination>();

            foreach (var sourceProperty in source.GetType().GetProperties())
            {
                var destinationProperty = typeof(TDestination).GetProperty(sourceProperty.Name);
                if (destinationProperty != null && destinationProperty.CanWrite)
                {
                    var value = sourceProperty.GetValue(source);
                    destinationProperty.SetValue(destination, value);
                }
            }

            return destination;
        }
        public static List<TDestination> ConvertToD<TDestination>(this IEnumerable<object> sourceList)
        {
            if (sourceList == null)
            {
                throw new ArgumentNullException(nameof(sourceList), "Source list cannot be null");
            }

            var destinationList = new List<TDestination>();

            foreach (var source in sourceList)
            {
                var destination = source.ConvertToDynamic<TDestination>();
                destinationList.Add(destination);
            }

            return destinationList;
        }
    }
}
