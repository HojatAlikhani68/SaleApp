using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale.Persistence.DbContextes
{
    internal class ApplicationDynamicDbContext : DbContext
    {
        public ApplicationDynamicDbContext(DbContextOptions<ApplicationDynamicDbContext> options)
        : base(options)
        {
        }

        public DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // می‌توانید تنظیمات مربوط به موجودیت‌ها را در اینجا اضافه کنید
            // به عنوان مثال:
            // modelBuilder.Entity<Discount>().ToTable("Discounts");
            // modelBuilder.Entity<DiscountCondition>().ToTable("DiscountConditions");
            // modelBuilder.Entity<DiscountConditionType>().ToTable("DiscountConditionTypes");
        }
    }
}
