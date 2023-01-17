namespace Traversal.Core.DTOs.Concretes.TestimonialDtos
{
    public class TestimonialUpdateDto
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public string UpdatedByName { get; set; }
    }
}
