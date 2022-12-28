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
    internal class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();
            builder.Property(c => c.Address).IsRequired().HasMaxLength(150);
            builder.Property(c => c.Description).IsRequired().HasMaxLength(300);
            builder.Property(c => c.Mail).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Phone).IsRequired().HasMaxLength(13);
            builder.Property(c => c.MapLocation).IsRequired().HasMaxLength(300);

            builder.Property(c => c.CreatedByName).IsRequired().HasMaxLength(50);
            builder.Property(c => c.UpdatedByName).IsRequired().HasMaxLength(50);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.UpdatedDate).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.ToTable("Contacts");
        }
    }
}
