using System.Collections.Generic;
using MySQL_bloggr.Models;

namespace MySQL_bloggr.Services
{
  public class BlogsService
  {
    public IEnumerable<Blog> GetAll()
    {
      return new List<Blog>() {new Blog() };
    }
  }
}