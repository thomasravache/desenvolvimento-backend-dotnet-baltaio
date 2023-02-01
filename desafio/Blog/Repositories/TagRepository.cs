using Blog.DTOs;
using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class TagRepository : Repository<Tag>
    {
        private readonly SqlConnection _connection;

        public TagRepository(SqlConnection connection) : base(connection)
            => _connection = connection;

        public IEnumerable<TagWithPostsCountDTO> GetWithPostsCount()
        {
            var query = @"
            SELECT
                [Tag].[Id] AS [TagId],
                [Tag].[Name] AS [TagName],
                COUNT([PostTag].[PostId]) AS [PostsCount]
            FROM
                [PostTag]
                INNER JOIN [Tag] ON [Tag].[Id] = [PostTag].[TagId]
            GROUP BY
                [Tag].[Id],
                [Tag].[Name]
            ";

            return _connection.Query<TagWithPostsCountDTO>(query);
        }
    }
}