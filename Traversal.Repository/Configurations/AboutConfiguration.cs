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
    internal class AboutConfiguration : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).UseIdentityColumn();
            builder.Property(a => a.Title).IsRequired().HasMaxLength(100);
            builder.Property(a => a.Title2).IsRequired().HasMaxLength(30);
            builder.Property(a => a.Description).IsRequired().HasMaxLength(350);
            builder.Property(a => a.Description2).IsRequired().HasMaxLength(350);
            builder.Property(a => a.Image).IsRequired().HasMaxLength(300);

            builder.Property(a => a.CreatedByName).IsRequired().HasMaxLength(50);
            builder.Property(a => a.UpdatedByName).IsRequired().HasMaxLength(50);
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.UpdatedDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.ToTable("Abouts");
        }
    }
}
