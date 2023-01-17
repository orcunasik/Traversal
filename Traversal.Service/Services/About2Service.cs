using Traversal.Core.Models.Concrete;
using Traversal.Core.Repositories;
using Traversal.Core.Services;
using Traversal.Core.UnitOfWorks;

namespace Traversal.Service.Services
{
    public class About2Service : Service<About2>, IAbout2Service
    {
        public About2Service(IGenericRepository<About2> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
