using Traversal.Core.DTOs.Abstract;

namespace Traversal.Core.DTOs.Concretes.TestimonialDtos
{
    public class TestimonialAddDto : BaseDto
    {
        public string Client { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
    }
}
