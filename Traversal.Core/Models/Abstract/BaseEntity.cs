namespace Traversal.Core.Models.Abstract
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime UpdatedDate { get; set; } = DateTime.Now;
        public virtual bool IsDeleted { get; set; } = false;
        public virtual bool IsActive { get; set; } = true;
        public virtual string CreatedByName { get; set; }
        public virtual string UpdatedByName { get; set; }
    }
}
