using Blog.DTOs;
using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class CategoryRepository : Repository<Category>
    {
        private readonly SqlConnection _connection;

        public CategoryRepository(SqlConnection connection) : base(connection)
            => _connection = connection;

        public List<Category> GetWithPost()
        {
            var query = @"
                SELECT
                    [Category].*,
                    [Post].*
                FROM
                    [Category]
                    INNER JOIN [Post] ON [Post].[CategoryId] = [Category].[Id]
            ";

            var categories = new List<Category>();
            var items = _connection.Query<Category, Post, Category>(
                query,
                (category, post) =>
                {
                    var ctg = categories.FirstOrDefault(x => x.Id == category.Id);

                    if (ctg == null)
                    {
                        ctg = category;

                        if (post != null)
                            ctg.Posts.Add(post);

                        categories.Add(ctg);
                    }
                    else
                    {
                        ctg.Posts.Add(post);
                    }

                    return category;
                },
                splitOn: "Id"
            );

            return categories;
        }

        public IEnumerable<CategoryWithPostsCountDTO> GetWithPostsCount()
        {
            var query = @"
                SELECT
                    [Category].[Name] AS [CategoryTitle],
                    COUNT([Post].[Id]) AS [PostsCount]
                FROM
                    [Category]
                    INNER JOIN [Post] ON [Post].[CategoryId] = [Category].[Id]
                GROUP BY
                    [Category].[Name]
            ";

            return _connection.Query<CategoryWithPostsCountDTO>(query);
        }
    }
}