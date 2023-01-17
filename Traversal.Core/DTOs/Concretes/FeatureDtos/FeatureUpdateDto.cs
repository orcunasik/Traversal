namespace Traversal.Core.DTOs.Concretes.FeatureDtos
{
    public class FeatureUpdateDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public string ThumbnailBig { get; set; }
        public int ViewsCount { get; set; }
        public int CommentCount { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public string UpdatedByName { get; set; }
    }
}
