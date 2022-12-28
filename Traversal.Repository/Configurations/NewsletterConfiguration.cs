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
    internal class NewsletterConfiguration : IEntityTypeConfiguration<Newsletter>
    {
        public void Configure(EntityTypeBuilder<Newsletter> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Id).UseIdentityColumn();
            builder.Property(n => n.Mail).IsRequired().HasMaxLength(100);

            builder.Property(n => n.CreatedByName).IsRequired().HasMaxLength(50);
            builder.Property(n => n.UpdatedByName).IsRequired().HasMaxLength(50);
            builder.Property(n => n.CreatedDate).IsRequired();
            builder.Property(n => n.UpdatedDate).IsRequired();
            builder.Property(n => n.IsActive).IsRequired();
            builder.Property(n => n.IsDeleted).IsRequired();
            builder.ToTable("Newsletters");
        }
    }
}
