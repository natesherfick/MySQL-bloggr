using System.Collections.Generic;
using MySQL_bloggr.Models;
using MySQL_bloggr.Repositories;

namespace MySQL_bloggr.Services
{
  public class BlogsService
  {
    private readonly BlogsRepository _repo;

    public BlogsService(BlogsRepository repo)
    {
      _repo = repo;
    }
    public IEnumerable<Blog> GetAll()
    {
      return _repo.GetAll();
    }
  }
}