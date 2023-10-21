using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DB.Configurations
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // This configuration below is for relationship
            builder.HasOne(p => p.Country)
                   .WithMany(c => c.Products)
                   .HasForeignKey(p => p.OriginCountry);
        }
    }
}
