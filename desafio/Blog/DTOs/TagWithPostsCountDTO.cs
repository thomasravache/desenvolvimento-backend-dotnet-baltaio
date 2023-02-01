namespace Blog.DTOs
{
    public class TagWithPostsCountDTO
    {
        public int TagId { get; set; }
        public string TagName { get; set; } = null!;
        public int PostsCount { get; set; }
    }
}