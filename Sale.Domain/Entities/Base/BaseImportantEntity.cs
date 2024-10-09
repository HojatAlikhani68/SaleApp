namespace Sale.Domain.Entities.Base
{
    public abstract class BaseImportantEntity<TKey> : BaseEntity<TKey>
    {          
        public int CreatedBy { get; set; } = 0;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
    }
}
