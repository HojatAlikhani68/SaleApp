using Sale.Domain.Entities.Base;
using Sale.Domain.Entities.Products;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Sale.Domain.Entities.Discounts
{
    public class Discount : BaseEntity<int>
    {
        public string Code { get; set; }
        public decimal Value { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; } = true;
        public ICollection<DiscountCondition> Conditions { get; set; } = [];

        // متد برای بررسی اعتبار تخفیف
        public bool IsValid(DateTime date, decimal totalPurchaseAmount, int totalLines, bool isCashPayment, ICollection<string> products)
        {
            return IsActive
                && date >= StartDate
                && date <= EndDate
                && Conditions.All(condition => condition.IsMet(totalPurchaseAmount, totalLines, isCashPayment, products));
        }
    }
    public class DiscountConditionType : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<DiscountCondition> Conditions { get; set; } =[];
    }
    public class DiscountCondition : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int DiscountConditionTypeId { get; set; }

        [ForeignKey("DiscountConditionTypeId")]
        public DiscountConditionType DiscountConditionType { get; set; }

        public decimal ConditionValue { get; set; }
        public ICollection<string> SpecificProducts { get; set; } = [];

        // متد برای بررسی اینکه آیا شرط برآورده شده است یا خیر
        public bool IsMet(decimal totalPurchaseAmount, int totalLines, bool isCashPayment, ICollection<string> products)
        {
            return DiscountConditionType.Name switch
            {
                "Minimum Purchase Amount" => totalPurchaseAmount >= ConditionValue,
                "Minimum Line Items" => totalLines >= (int)ConditionValue,
                "Cash Payment Only" => isCashPayment,
                "Specific Products Required" => SpecificProducts.Count > 0 && SpecificProducts.Any(p => products.Contains(p)),
                _ => true
            };
        }
    }
}