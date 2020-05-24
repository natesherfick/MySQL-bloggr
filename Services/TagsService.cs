using System;
using System.Collections.Generic;
using MySQL_bloggr.Models;
using MySQL_bloggr.Repositories;

namespace MySQL_bloggr.Services
{
  public class TagsService
  {
    private readonly TagsRepository _repo;

    public TagsService(TagsRepository repo)
    {
      _repo = repo;
    }

    internal Tag Create(Tag newTag)
    {
      return _repo.Create(newTag);
    }

    internal  IEnumerable<Tag> GetAll()
    {
      return _repo.GetAll();
    }
  }
}