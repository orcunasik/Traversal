using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.DTOs.Abstract;

namespace Traversal.Core.DTOs
{
    public class TestimonialDto :BaseDto
    {
        public string Client { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
    }
}
