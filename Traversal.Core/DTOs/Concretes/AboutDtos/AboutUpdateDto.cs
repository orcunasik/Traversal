namespace Traversal.Core.DTOs.Concretes.AboutDtos
{
    public class AboutUpdateDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string Image { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public string UpdatedByName { get; set; }
    }
}
