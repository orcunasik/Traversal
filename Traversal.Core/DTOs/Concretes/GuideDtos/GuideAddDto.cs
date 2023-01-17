using Traversal.Core.DTOs.Abstract;

namespace Traversal.Core.DTOs.Concretes.GuideDtos
{
    public class GuideAddDto : BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }
    }
}
