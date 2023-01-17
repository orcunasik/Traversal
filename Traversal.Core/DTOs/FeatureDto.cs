using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.DTOs.Abstract;

namespace Traversal.Core.DTOs
{
    public class FeatureDto : BaseDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public string ThumbnailBig { get; set; }
        public int ViewsCount { get; set; }
        public int CommentCount { get; set; }
    }
}
