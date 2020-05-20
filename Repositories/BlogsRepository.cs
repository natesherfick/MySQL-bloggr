using System;
using System.Collections.Generic;
using System.Data;
using MySQL_bloggr.Models;

namespace MySQL_bloggr.Repositories
{
  public class BlogsRepository
  {
    private readonly IDbConnection _db;

    public BlogsRepository(IDbConnection db)
    {
        _db = db;
    }
    internal IEnumerable<Blog> GetAll()
    {
      
    }
  }
}