
namespace Library.Models
{
  public class Book
  {
    public int BookId { get; set; }
    public string Book { get; set; }

    // Collection Navigation Property (For Many-to-Many Relationship with Author)
    public List<AuthorBook> JoinEntities { get; set; }
  }
}