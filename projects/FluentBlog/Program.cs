using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new BlogDataContext();

            var postsWithCount = context.PostWithTagsCount.ToList();

            foreach (var item in postsWithCount)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Count);
            }
        }
    }
}