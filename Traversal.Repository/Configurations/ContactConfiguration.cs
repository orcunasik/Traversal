using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traversal.Core.Models.Concrete;

namespace Traversal.Repository.Configurations
{
    public class ContactConfiguration : BaseEntityConfiguration<Contact>
    {
        public override void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();
            builder.Property(c => c.Address).IsRequired().HasMaxLength(150);
            builder.Property(c => c.Description).IsRequired().HasMaxLength(300);
            builder.Property(c => c.Mail).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Phone).IsRequired().HasMaxLength(13);
            builder.Property(c => c.MapLocation).IsRequired().HasMaxLength(300);

            builder.ToTable("Contacts");
        }
    }
}
