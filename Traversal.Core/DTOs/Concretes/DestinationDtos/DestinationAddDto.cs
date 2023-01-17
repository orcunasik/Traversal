using Traversal.Core.DTOs.Abstract;

namespace Traversal.Core.DTOs.Concretes.DestinationDtos
{
    public class DestinationAddDto : BaseDto
    {
        public string City { get; set; }
        public string DurationOfStay { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
    }
}
