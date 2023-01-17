using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traversal.Core.Models.Concrete;

namespace Traversal.Repository.Configurations
{
    public class TestimonialConfiguration : BaseEntityConfiguration<Testimonial>
    {
        public override void Configure(EntityTypeBuilder<Testimonial> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).UseIdentityColumn();
            builder.Property(t => t.Client).IsRequired().HasMaxLength(50);
            builder.Property(t => t.Comment).IsRequired().HasMaxLength(300);
            builder.Property(t => t.Image).IsRequired().HasMaxLength(300);

            builder.ToTable("Testimonials");
        }
    }
}
