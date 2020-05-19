using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MySQL_bloggr.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BlogsController : ControllerBase
  {
    public ActionResult<string> GetAll()
    {
      try
      {
        return Ok("got blogs");
      }
      catch (System.Exception)
      {
        throw;
      }
    }
  }
}