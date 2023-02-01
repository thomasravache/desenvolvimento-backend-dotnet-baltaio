namespace Blog.DTOs
{
    public class CategoryWithPostsCountDTO
    {
        public string CategoryTitle { get; set; } = null!;
        public int PostsCount { get; set; }
    }
}