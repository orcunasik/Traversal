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
    public class NewsletterRepository : GenericRepository<Newsletter>,INewsletterRepository
    {
        public NewsletterRepository(TraversalContext context) : base(context)
        {
        }
    }
}
