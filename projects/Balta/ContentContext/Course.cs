using Balta.ContentContext.Enums;

namespace Balta.ContentContext
{
  public class Course : Content
  {
    public Course()
    {
      Modules = new List<Module>(); // sempre inicializar as listas
    }

    public string Tag { get; set; }
    public IList<Module> Modules { get; set; }
    public EContentLevel Level { get; set; }
  }
}