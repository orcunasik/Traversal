namespace Traversal.Core.DTOs.Concretes.About2Dtos
{
    public class About2UpdateDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public string UpdatedByName { get; set; }
    }
}
