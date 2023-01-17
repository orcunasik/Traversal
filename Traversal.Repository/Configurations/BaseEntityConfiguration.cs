using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traversal.Core.Models.Abstract;

namespace Traversal.Repository.Configurations
{
    public abstract class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).UseIdentityColumn();
            builder.Property(i => i.CreatedByName).IsRequired().HasMaxLength(50);
            builder.Property(i => i.UpdatedByName).IsRequired().HasMaxLength(50);
            builder.Property(i => i.CreatedDate).IsRequired();
            builder.Property(i => i.UpdatedDate).IsRequired();
            builder.Property(i => i.IsActive).IsRequired();
            builder.Property(i => i.IsDeleted).IsRequired();
        }
    }
}
