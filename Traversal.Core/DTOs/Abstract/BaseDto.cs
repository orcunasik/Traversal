namespace Traversal.Core.DTOs.Abstract
{
    public abstract class BaseDto
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public string CreatedByName { get; set; }
        public string UpdatedByName { get; set; }
    }
}
