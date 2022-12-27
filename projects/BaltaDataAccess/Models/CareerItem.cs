namespace BaltaDataAccess.Models
{
  public class CareerItem
  {
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public Course? Course { get; set; }
  }
}