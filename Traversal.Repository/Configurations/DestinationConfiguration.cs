using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traversal.Core.Models.Concrete;

namespace Traversal.Repository.Configurations
{
    public class DestinationConfiguration : BaseEntityConfiguration<Destination>
    {
        public override void Configure(EntityTypeBuilder<Destination> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Id).UseIdentityColumn();
            builder.Property(d => d.Capacity).IsRequired();
            builder.Property(d => d.City).IsRequired().HasMaxLength(50);
            builder.Property(d => d.Description).IsRequired().HasMaxLength(350);
            builder.Property(d => d.DurationOfStay).IsRequired().HasMaxLength(50);
            builder.Property(d => d.Price).IsRequired().HasColumnType("decimal(18,2)");

            builder.ToTable("Destinations");
        }
    }
}
