using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Models.Concrete;

namespace Traversal.Repository.Configurations
{
    internal class FeatureConfiguration : IEntityTypeConfiguration<Feature>
    {
        public void Configure(EntityTypeBuilder<Feature> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Id).UseIdentityColumn();
            builder.Property(f => f.Description).IsRequired().HasMaxLength(300);
            builder.Property(f => f.Title).IsRequired().HasMaxLength(100);
            builder.Property(f => f.Thumbnail).IsRequired().HasMaxLength(300);
            builder.Property(f => f.ThumbnailBig).IsRequired().HasMaxLength(300);
            builder.Property(f => f.ViewsCount).IsRequired();
            builder.Property(f => f.CommentCount).IsRequired();

            builder.Property(f => f.CreatedByName).IsRequired().HasMaxLength(50);
            builder.Property(f => f.UpdatedByName).IsRequired().HasMaxLength(50);
            builder.Property(f => f.CreatedDate).IsRequired();
            builder.Property(f => f.UpdatedDate).IsRequired();
            builder.Property(f => f.IsActive).IsRequired();
            builder.Property(f => f.IsDeleted).IsRequired();
            builder.ToTable("Features");
        }
    }
}
