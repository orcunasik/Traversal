using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traversal.Core.Models.Concrete;

namespace Traversal.Repository.Configurations
{
    public class About2Configuration : BaseEntityConfiguration<About2>
    {
        public override void Configure(EntityTypeBuilder<About2> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).UseIdentityColumn();
            builder.Property(a => a.Title).IsRequired().HasMaxLength(100);
            builder.Property(a => a.Description).IsRequired().HasMaxLength(350);
            builder.Property(a => a.Image).IsRequired().HasMaxLength(300);

            builder.ToTable("About2s");
        }
    }
}
