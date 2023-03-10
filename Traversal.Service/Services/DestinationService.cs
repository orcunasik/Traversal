using Traversal.Core.Models.Concrete;
using Traversal.Core.Repositories;
using Traversal.Core.Services;
using Traversal.Core.UnitOfWorks;

namespace Traversal.Service.Services
{
    public class DestinationService : Service<Destination>, IDestinationService
    {
        public DestinationService(IGenericRepository<Destination> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
