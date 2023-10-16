using System;
using System.Collections.Generic;

namespace Library.Models
{
  public class Book
  {
    public int BookId { get; set; }
    public string Title { get; set; }

    // Collection Navigation Property (For Many-to-Many Relationship with Author)
    public List<AuthorBook> JoinEntities { get; set; }
  }
}