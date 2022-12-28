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
    internal class TestimonialConfiguration : IEntityTypeConfiguration<Testimonial>
    {
        public void Configure(EntityTypeBuilder<Testimonial> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).UseIdentityColumn();
            builder.Property(t => t.Client).IsRequired().HasMaxLength(50);
            builder.Property(t => t.Comment).IsRequired().HasMaxLength(300);
            builder.Property(t => t.Image).IsRequired().HasMaxLength(300);

            builder.Property(t => t.CreatedByName).IsRequired().HasMaxLength(50);
            builder.Property(t => t.UpdatedByName).IsRequired().HasMaxLength(50);
            builder.Property(t => t.CreatedDate).IsRequired();
            builder.Property(t => t.UpdatedDate).IsRequired();
            builder.Property(t => t.IsActive).IsRequired();
            builder.Property(t => t.IsDeleted).IsRequired();
            builder.ToTable("Testimonials");
        }
    }
}
