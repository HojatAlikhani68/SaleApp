﻿using Sale.Domain.Entities.Base;
using Sale.Domain.Entities.Products;


namespace Sale.Domain.Entities.Discounts
{
    public class Discount:BaseImportantEntity<int>
    {
        public required string Title { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public float Percentage { get; set; }
        public decimal Price { get; set; }
        public Product Product { get; set; }
    }
}
