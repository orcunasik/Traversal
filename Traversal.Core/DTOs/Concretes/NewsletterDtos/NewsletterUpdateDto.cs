namespace Traversal.Core.DTOs.Concretes.NewsletterDtos
{
    public class NewsletterUpdateDto
    {
        public int Id { get; set; }
        public string Mail { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public string UpdatedByName { get; set; }
    }
}
