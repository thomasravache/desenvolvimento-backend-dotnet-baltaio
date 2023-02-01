using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class PostRepository : Repository<Post>
    {
        private readonly SqlConnection _connection;

        public PostRepository(SqlConnection connection) : base(connection)
            => _connection = connection;

        public IEnumerable<Post> GetByCategoryId(int categoryId)
        {
            var query = @"
                SELECT
                    *
                FROM
                    [Post]
                WHERE
                    [CategoryId] = @CategoryId
            ";

            var parameters = new
            {
                CategoryId = categoryId,
            };

            return _connection.Query<Post>(query, parameters);
        }

        public IEnumerable<Post> GetWithCategory()
        {
            var query = @"
                SELECT
                    *
                FROM
                    [Post]
                    INNER JOIN [Category] ON [Category].[Id] = [Post].[CategoryId]
            ";

            var posts = _connection.Query<Post, Category, Post>(
                query,
                (post, category) =>
                {
                    post.Category = category;

                    return post;
                },
                splitOn: "Id"
            );

            return posts;
        }

        public List<Post> GetWithTags()
        {
            var query = @"
                SELECT
                    [Post].*,
                    [Tag].*
                FROM
                    [Post]
                    LEFT JOIN [PostTag] ON [PostTag].[PostId] = [Post].[Id]
                    LEFT JOIN [Tag] ON [Tag].[Id] = [PostTag].[TagId]
            ";

            var posts = new List<Post>();

            var items = _connection.Query<Post, Tag, Post>(
                query,
                (post, tag) =>
                {
                    var pst = posts.FirstOrDefault(x => x.Id == post.Id);

                    if (pst == null)
                    {
                        pst = post;

                        if (tag != null)
                            pst.Tags.Add(tag);

                        posts.Add(pst);
                    }

                    return post;
                },
                splitOn: "Id"
            );

            return posts;
        }
    }
}