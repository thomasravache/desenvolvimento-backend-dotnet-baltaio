using Blog.Data.Mappings;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class BlogDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<PostWithTagsCount> PostWithTagsCount { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=127.0.0.1,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$");
            // options.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new PostMap());

            modelBuilder.Entity<PostWithTagsCount>(x =>
            {
                // Pode ser uma View também
                x.ToSqlQuery(@"
                    SELECT
                        [Title] AS [Name],
                        SELECT COUNT([Id]) FROM [Tags] WHERE [PostId] = [Id]
                            AS [Count]
                    FROM
                        [Posts]
                ");
            });
        }
    }
}