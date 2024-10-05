using System.ComponentModel.DataAnnotations;

namespace Sale.Domain.Entities.Base
{
    public abstract class BaseImportantEntity<TKey> : BaseEntity<TKey>
    {
        public DateTime DateTime { get; set; }
        public int UserInsert { get; set; } = 0;
        public int? UserUpdate { get; set; }
        public DateTime InsertDate { get; set; }= DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        [Timestamp]
        public byte Timestamp { get; set; }
        public bool IsActive { get; set; }

    }
}
