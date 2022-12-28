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
    internal class SubAboutConfiguration : IEntityTypeConfiguration<SubAbout>
    {
        public void Configure(EntityTypeBuilder<SubAbout> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).UseIdentityColumn();
            builder.Property(s => s.Description).IsRequired().HasMaxLength(300);
            builder.Property(s => s.Title).IsRequired().HasMaxLength(100);

            builder.Property(s => s.CreatedByName).IsRequired().HasMaxLength(50);
            builder.Property(s => s.UpdatedByName).IsRequired().HasMaxLength(50);
            builder.Property(s => s.CreatedDate).IsRequired();
            builder.Property(s => s.UpdatedDate).IsRequired();
            builder.Property(s => s.IsActive).IsRequired();
            builder.Property(s => s.IsDeleted).IsRequired();
            builder.ToTable("SubAbouts");
        }
    }
}
