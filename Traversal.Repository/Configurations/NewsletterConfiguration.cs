using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traversal.Core.Models.Concrete;

namespace Traversal.Repository.Configurations
{
    public class NewsletterConfiguration : BaseEntityConfiguration<Newsletter>
    {
        public override void Configure(EntityTypeBuilder<Newsletter> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Id).UseIdentityColumn();
            builder.Property(n => n.Mail).IsRequired().HasMaxLength(100);

            builder.ToTable("Newsletters");
        }
    }
}
