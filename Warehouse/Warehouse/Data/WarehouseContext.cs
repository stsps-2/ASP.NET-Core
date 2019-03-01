using Microsoft.EntityFrameworkCore;

namespace Warehouse.Data.Models
{
    public partial class WarehouseContext: DbContext
    {
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Quantity)
                    .IsRequired();

                entity.Property(e => e.DefaultValue);
            });
        }
    }
}