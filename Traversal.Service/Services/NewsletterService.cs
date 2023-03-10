using Traversal.Core.Models.Concrete;
using Traversal.Core.Repositories;
using Traversal.Core.Services;
using Traversal.Core.UnitOfWorks;

namespace Traversal.Service.Services
{
    public class NewsletterService : Service<Newsletter>, INewsletterService
    {
        public NewsletterService(IGenericRepository<Newsletter> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
