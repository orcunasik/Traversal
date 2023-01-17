using Traversal.Core.Models.Concrete;
using Traversal.Core.Repositories;
using Traversal.Core.Services;
using Traversal.Core.UnitOfWorks;

namespace Traversal.Service.Services
{
    public class AboutService : Service<About>, IAboutService
    {
        public AboutService(IGenericRepository<About> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
