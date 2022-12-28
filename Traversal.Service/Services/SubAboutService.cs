using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Models.Concrete;
using Traversal.Core.Repositories;
using Traversal.Core.Services;
using Traversal.Core.UnitOfWorks;

namespace Traversal.Service.Services
{
    public class SubAboutService : Service<SubAbout>, ISubAboutService
    {
        public SubAboutService(IGenericRepository<SubAbout> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
