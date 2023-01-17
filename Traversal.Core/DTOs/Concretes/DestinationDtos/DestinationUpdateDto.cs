namespace Traversal.Core.DTOs.Concretes.DestinationDtos
{
    public class DestinationUpdateDto
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string DurationOfStay { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public string UpdatedByName { get; set; }
    }
}
