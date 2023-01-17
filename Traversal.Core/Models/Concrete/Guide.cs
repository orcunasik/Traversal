using Traversal.Core.Models.Abstract;

namespace Traversal.Core.Models.Concrete
{
    public class Guide : BaseEntity, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }
    }
}
