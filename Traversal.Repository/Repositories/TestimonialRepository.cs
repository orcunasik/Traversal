using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Models.Concrete;
using Traversal.Core.Repositories;
using Traversal.Repository.Concretes;

namespace Traversal.Repository.Repositories
{
    public class TestimonialRepository : GenericRepository<Testimonial>,ITestimonialRepository
    {
        public TestimonialRepository(TraversalContext context) : base(context)
        {
        }
    }
}
