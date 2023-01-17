using Traversal.Core.DTOs.Abstract;

namespace Traversal.Core.DTOs.Concretes.ContactDtos
{
    public class ContactAddDto : BaseDto
    {
        public string Description { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string MapLocation { get; set; }
    }
}
