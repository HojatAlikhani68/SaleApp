using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale.Domain.Enumerations
{
    public enum ProductStatus:byte
    {
        Unknown,
        Salable = 1,
        UnSellable = 2,
    }
}
