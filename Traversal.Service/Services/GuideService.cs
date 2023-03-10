using Traversal.Core.Models.Concrete;
using Traversal.Core.Repositories;
using Traversal.Core.Services;
using Traversal.Core.UnitOfWorks;

namespace Traversal.Service.Services
{
    public class GuideService : Service<Guide>, IGuideService
    {
        public GuideService(IGenericRepository<Guide> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
