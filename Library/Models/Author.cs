using System;
using System.Collections.Generic;

namespace Library.Models
{
  public class Author
  {
    public int AuthorId { get; set;}
    public string Name { get; set; }

    // Collection Navigation Property (For Many-to-Many Relationship with Book)
    public List<AuthorBook> JoinEntities { get; set; }
  }
}