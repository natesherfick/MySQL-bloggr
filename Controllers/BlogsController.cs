using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySQL_bloggr.Models;
using MySQL_bloggr.Services;

namespace MySQL_bloggr.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BlogsController : ControllerBase
  {
    private readonly BlogsService _bs;

    public BlogsController(BlogsService bs)
    {
      _bs = bs;
    }


    [HttpGet]
    public ActionResult<IEnumerable<Blog>> GetAll()
    {
      try
      {
        return Ok(_bs.GetAll());
      }
      catch (System.Exception)
      {
        throw;
      }
    }

    [HttpGet("user")]
    public ActionResult<IEnumerable<Blog>> GetBlogsByUserEmail()
    {
      try
      {   
        string creatorEmail = "testemail@static.com";
          return Ok(_bs.GetBlogsByUserEmail(creatorEmail));
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Blog> GetById(int id)
    {
      try
      {
          return Ok(_bs.GetById(id));
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<Blog> Create([FromBody] Blog newBlog)
    {
      try
      {
        newBlog.CreatorEmail = "testemail@static.com";
        return Ok(_bs.Create(newBlog));
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<Blog> Delete(int id)
    {
      try
      {
          return Ok(_bs.Delete(id));
      }
      catch (System.Exception err)
      {
       return BadRequest(err.Message);
      }
    }

    [HttpPut]
    public ActionResult<Blog> Edit(int id, [FromBody] Blog updatedBlog)
    {
      try
      {
          return Ok(_bs.Edit(id, updatedBlog));
      }
      catch (System.Exception err)
      {
      return BadRequest(err.Message);
      }
    }
  }
}