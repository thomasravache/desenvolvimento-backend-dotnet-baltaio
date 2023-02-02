using Blog.Data;
using Blog.Models;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
                // var tag = new Tag { Name = "ASP.NET", Slug = "aspnet2" };

                // context.Tags.Add(tag);
                // context.SaveChanges();

                // var tag = context.Tags.FirstOrDefault(x => x.Id == 1003);

                // if (tag == null)
                //     return;

                // tag.Name = ".NET";
                // tag.Slug = "dotnet";

                // context.Update(tag);
                // context.SaveChanges();

                // var tag = context.Tags.FirstOrDefault(x => x.Id == 1003);

                // context.Remove(tag);
                // context.SaveChanges();

                // var tags = context.Tags; // apenas a referencia
                var tags = context.Tags.ToList(); // executa a query no banco nesta linha

                // SEMPRE UTILIZAR O ToList() por último

                foreach (var tag in tags)
                {
                    Console.WriteLine(tag.Name);
                }
            }
        }
    }
}