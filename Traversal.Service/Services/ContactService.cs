using Traversal.Core.Models.Concrete;
using Traversal.Core.Repositories;
using Traversal.Core.Services;
using Traversal.Core.UnitOfWorks;

namespace Traversal.Service.Services
{
    public class ContactService : Service<Contact>, IContactService
    {
        public ContactService(IGenericRepository<Contact> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
