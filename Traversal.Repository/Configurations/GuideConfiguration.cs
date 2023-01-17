using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traversal.Core.Models.Concrete;

namespace Traversal.Repository.Configurations
{
    public class GuideConfiguration : BaseEntityConfiguration<Guide>
    {
        public override void Configure(EntityTypeBuilder<Guide> builder)
        {
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Id).UseIdentityColumn();
            builder.Property(g => g.Description).IsRequired().HasMaxLength(300);
            builder.Property(g => g.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(g => g.LastName).IsRequired().HasMaxLength(50);
            builder.Property(g => g.Image).IsRequired().HasMaxLength(300);
            builder.Property(g => g.InstagramUrl).IsRequired().HasMaxLength(150);
            builder.Property(g => g.TwitterUrl).IsRequired().HasMaxLength(150);

            builder.ToTable("Guides");
        }
    }
}
