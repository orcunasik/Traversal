using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traversal.Core.Models.Concrete;

namespace Traversal.Repository.Configurations
{
    public class FeatureConfiguration : BaseEntityConfiguration<Feature>
    {
        public override void Configure(EntityTypeBuilder<Feature> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Id).UseIdentityColumn();
            builder.Property(f => f.Description).IsRequired().HasMaxLength(300);
            builder.Property(f => f.Title).IsRequired().HasMaxLength(100);
            builder.Property(f => f.Thumbnail).IsRequired().HasMaxLength(300);
            builder.Property(f => f.ThumbnailBig).IsRequired().HasMaxLength(300);
            builder.Property(f => f.ViewsCount).IsRequired();
            builder.Property(f => f.CommentCount).IsRequired();

            builder.ToTable("Features");
        }
    }
}
