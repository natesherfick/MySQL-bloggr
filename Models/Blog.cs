using System.ComponentModel.DataAnnotations;

namespace MySQL_bloggr.Models
{
  public class Blog
  {
    public int Id { get; set; }

    [Required]
    [MaxLength(80)]
    public string Title { get; set; }
    public string Body { get; set; }
    public bool IsPublished { get; set; }
    public string CreatorEmail { get; set; }
  }
}