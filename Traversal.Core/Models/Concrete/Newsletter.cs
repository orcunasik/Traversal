using Traversal.Core.Models.Abstract;

namespace Traversal.Core.Models.Concrete
{
    public class Newsletter : BaseEntity, IEntity
    {
        public string Mail { get; set; }
    }
}
