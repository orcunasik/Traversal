using Traversal.Core.Models.Abstract;

namespace Traversal.Core.Models.Concrete
{
    public class SubAbout : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
