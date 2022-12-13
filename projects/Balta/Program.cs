using Balta.ContentContext;

namespace Balta
{
  class Program
  {
    static void Main(string[] args)
    {
      var course = new Course();
      course.Level = ContentContext.Enums.EContentLevel.Beginner;
    }
  }
}