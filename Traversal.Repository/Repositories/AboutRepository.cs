using Traversal.Core.Models.Concrete;
using Traversal.Core.Repositories;
using Traversal.Repository.Concretes;

namespace Traversal.Repository.Repositories
{
    public class AboutRepository : GenericRepository<About>, IAboutRepository
    {
        public AboutRepository(TraversalContext context) : base(context)
        {
        }
    }
}
