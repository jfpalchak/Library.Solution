using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
  public class LibraryContext : IdentityDbContext<ApplicationUser>
  {
    // public DbSet<ClassName> ClassName { get; set; }

    public LibraryContext(DbContextOptions options) : base(options) { }
  }
}