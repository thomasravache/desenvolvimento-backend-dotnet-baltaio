namespace Balta.ContentContext
{
  public abstract class Content
  {
    public Content()
    {
      Id = Guid.NewGuid();
    }

    public Guid Id { get; private set; }
    public string Title { get; set; }
    public string Url { get; set; }
  }
}