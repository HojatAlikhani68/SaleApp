using Sale.Domain.Entities.Base;

namespace Sale.Domain.Entities.Geographics
{
    public class Address : BaseEntity<int> { }
    public class Street : BaseEntity<int> { }
    public class City : BaseEntity<int> { }
    public class Area : BaseEntity<int> { }
    public class Region : BaseEntity<int> { }
    public class State : BaseEntity<int> { }
    public class Country : BaseEntity<short> { }
}
