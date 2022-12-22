using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Models.Abstract;

namespace Traversal.Core.Models.Concrete
{
    public class Testimonial : BaseEntity, IEntity
    {
        public string Client { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
    }
}
