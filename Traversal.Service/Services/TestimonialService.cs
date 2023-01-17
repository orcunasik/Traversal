using Traversal.Core.Models.Concrete;
using Traversal.Core.Repositories;
using Traversal.Core.Services;
using Traversal.Core.UnitOfWorks;

namespace Traversal.Service.Services
{
    public class TestimonialService : Service<Testimonial>, ITestimonialService
    {
        public TestimonialService(IGenericRepository<Testimonial> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
