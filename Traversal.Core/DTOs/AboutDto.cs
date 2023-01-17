using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.DTOs.Abstract;

namespace Traversal.Core.DTOs
{
    public class AboutDto : BaseDto
    {
        public string Title { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string Image { get; set; }
    }
}
