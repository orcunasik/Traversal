using Traversal.Core.Models.Concrete;
using Traversal.Core.Repositories;
using Traversal.Core.Services;
using Traversal.Core.UnitOfWorks;

namespace Traversal.Service.Services
{
    public class FeatureService : Service<Feature>, IFeatureService
    {
        public FeatureService(IGenericRepository<Feature> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
