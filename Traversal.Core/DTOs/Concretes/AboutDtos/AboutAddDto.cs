using Traversal.Core.DTOs.Abstract;

namespace Traversal.Core.DTOs.Concretes.AboutDtos
{
    public class AboutAddDto : BaseDto
    {
        public string Title { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string Image { get; set; }
    }
}
