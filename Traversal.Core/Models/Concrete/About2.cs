using Traversal.Core.Models.Abstract;

namespace Traversal.Core.Models.Concrete
{
    public class About2 : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
