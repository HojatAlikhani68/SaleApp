using System.ComponentModel.DataAnnotations;

namespace Sale.Domain.Entities.Base
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        [Timestamp]
        public byte[] RowVersion { get; set; }
        public bool IsActive { get; set; } = true;
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public int? DeletedBy { get; set; }
        // متد به‌روزرسانی تاریخ و کاربر تغییر دهنده
        public void MarkUpdated(int userId)
        {
            UpdatedDate = DateTime.UtcNow;
            UpdatedBy = userId;
        }
        // متد حذف نرم
        public void SoftDelete(int userId)
        {
            IsDeleted = true;
            IsActive = false;
            DeletedDate = DateTime.UtcNow;
            DeletedBy = userId;
        }
        // متد بازگرداندن از حذف نرم
        public void Restore(int userId)
        {
            IsDeleted = false;
            IsActive = true;
            MarkUpdated(userId);
            DeletedDate = null;
            DeletedBy = null;
        }
    }

}
