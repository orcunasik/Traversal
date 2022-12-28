using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Models.Concrete;
using Traversal.Repository.Concretes;

namespace Traversal.Repository.Repositories
{
    public class TestimonialRepository : GenericRepository<Testimonial>
    {
        public TestimonialRepository(TraversalContext context) : base(context)
        {
        }
    }
}
