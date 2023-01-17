using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traversal.Core.Models.Concrete;

namespace Traversal.Repository.Configurations
{
    public class AboutConfiguration : BaseEntityConfiguration<About>
    {
        public override void Configure(EntityTypeBuilder<About> builder)
        {
            base.Configure(builder);
            builder.Property(a => a.Title).IsRequired().HasMaxLength(100);
            builder.Property(a => a.Title2).IsRequired().HasMaxLength(30);
            builder.Property(a => a.Description).IsRequired().HasMaxLength(350);
            builder.Property(a => a.Description2).IsRequired().HasMaxLength(350);
            builder.Property(a => a.Image).IsRequired().HasMaxLength(300);

            builder.ToTable("Abouts");
        }
    }
}
