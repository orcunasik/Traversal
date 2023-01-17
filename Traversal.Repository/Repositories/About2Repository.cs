using Traversal.Core.Models.Concrete;
using Traversal.Core.Repositories;
using Traversal.Repository.Concretes;

namespace Traversal.Repository.Repositories
{
    public class About2Repository : GenericRepository<About2>, IAbout2Repository
    {
        public About2Repository(TraversalContext context) : base(context)
        {
        }
    }
}
