using System;
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

    internal object Create(Blog newBlog)
    {
      return _repo.Create(newBlog);
    }

    internal Blog GetById(int id)
    {
      Blog foundBlog =  _repo.GetById(id);
      if (foundBlog == null)
      {
        throw new Exception("Invalid id.");
      }
      return foundBlog;
    }
    internal IEnumerable<Blog> GetBlogsByUserEmail(string creatorEmail)
    {
      return _repo.GetBlogsByUserEmail(creatorEmail);
    }

    internal Blog Delete(int id)
    {
      Blog foundBlog = GetById(id);
      if (_repo.Delete(id))
      {
      return foundBlog;
      }
      throw new Exception("Sometihng went wrong with the delete...");
    }


    internal Blog Edit(int id, Blog updatedBlog)
    {
      Blog foundBlog = GetById(id);
      foundBlog.IsPublished = updatedBlog.IsPublished;
      foundBlog.Body = updatedBlog.Body;
      foundBlog.Title = updatedBlog.Title;
      return _repo.Edit(foundBlog);
    }
  }
}