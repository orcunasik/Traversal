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
    internal class DestinationConfiguration : IEntityTypeConfiguration<Destination>
    {
        public void Configure(EntityTypeBuilder<Destination> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Id).UseIdentityColumn();
            builder.Property(d => d.Capacity).IsRequired();
            builder.Property(d => d.City).IsRequired().HasMaxLength(50);
            builder.Property(d => d.Description).IsRequired().HasMaxLength(350);
            builder.Property(d => d.DurationOfStay).IsRequired().HasMaxLength(50);
            builder.Property(d => d.Price).IsRequired().HasColumnType("decimal(18,2)");

            builder.Property(d => d.CreatedByName).IsRequired().HasMaxLength(50);
            builder.Property(d => d.UpdatedByName).IsRequired().HasMaxLength(50);
            builder.Property(d => d.CreatedDate).IsRequired();
            builder.Property(d => d.UpdatedDate).IsRequired();
            builder.Property(d => d.IsActive).IsRequired();
            builder.Property(d => d.IsDeleted).IsRequired();
            builder.ToTable("Destinations");
        }
    }
}
