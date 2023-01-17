using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traversal.Core.Models.Concrete;

namespace Traversal.Repository.Configurations
{
    public class SubAboutConfiguration : BaseEntityConfiguration<SubAbout>
    {
        public override void Configure(EntityTypeBuilder<SubAbout> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).UseIdentityColumn();
            builder.Property(s => s.Description).IsRequired().HasMaxLength(300);
            builder.Property(s => s.Title).IsRequired().HasMaxLength(100);

            builder.ToTable("SubAbouts");
        }
    }
}
