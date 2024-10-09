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
        public static ICollection<TDestination> ConvertToICollection<TSource, TDestination>(this IEnumerable<TSource> sourceICollection)
        {
            if (sourceICollection == null)
            {
                throw new ArgumentNullException(nameof(sourceICollection), "Source ICollection cannot be null");
            }

            var destinationICollection = new ICollection<TDestination>();

            foreach (var source in sourceICollection)
            {
                var destination = source.ConvertTo<TSource, TDestination>();
                destinationICollection.Add(destination);
            }

            return destinationICollection;
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
        public static ICollection<TDestination> ConvertToD<TDestination>(this IEnumerable<object> sourceICollection)
        {
            if (sourceICollection == null)
            {
                throw new ArgumentNullException(nameof(sourceICollection), "Source ICollection cannot be null");
            }

            var destinationICollection = new ICollection<TDestination>();

            foreach (var source in sourceICollection)
            {
                var destination = source.ConvertToDynamic<TDestination>();
                destinationICollection.Add(destination);
            }

            return destinationICollection;
        }
    }
}
