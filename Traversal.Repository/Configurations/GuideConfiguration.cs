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
    internal class GuideConfiguration : IEntityTypeConfiguration<Guide>
    {
        public void Configure(EntityTypeBuilder<Guide> builder)
        {
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Id).UseIdentityColumn();
            builder.Property(g => g.Description).IsRequired().HasMaxLength(300);
            builder.Property(g => g.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(g => g.LastName).IsRequired().HasMaxLength(50);
            builder.Property(g => g.Image).IsRequired().HasMaxLength(300);
            builder.Property(g => g.InstagramUrl).IsRequired().HasMaxLength(150);
            builder.Property(g => g.TwitterUrl).IsRequired().HasMaxLength(150);

            builder.Property(g => g.CreatedByName).IsRequired().HasMaxLength(50);
            builder.Property(g => g.UpdatedByName).IsRequired().HasMaxLength(50);
            builder.Property(g => g.CreatedDate).IsRequired();
            builder.Property(g => g.UpdatedDate).IsRequired();
            builder.Property(g => g.IsActive).IsRequired();
            builder.Property(g => g.IsDeleted).IsRequired();
            builder.ToTable("Guides");
        }
    }
}
