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
    }
}