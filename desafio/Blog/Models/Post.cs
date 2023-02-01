using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("[Post]")]
    public class Post
    {
        public Post()
        {
            Tags = new List<Tag>();
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; } = null!;
        public string Summary { get; set; } = null!;
        public string Body { get; set; } = null!;
        public string Slug { get; set; } = null!;
        [Write(false)]
        public Category Category { get; set; } = null!;
        public List<Tag> Tags { get; set; }
        // public int CategoryIds { get; set; }
    }
}