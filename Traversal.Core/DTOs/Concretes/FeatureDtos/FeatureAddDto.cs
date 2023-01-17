using Traversal.Core.DTOs.Abstract;

namespace Traversal.Core.DTOs.Concretes.FeatureDtos
{
    public class FeatureAddDto : BaseDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public string ThumbnailBig { get; set; }
        public int ViewsCount { get; set; }
        public int CommentCount { get; set; }
    }
}
