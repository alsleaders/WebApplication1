using System.Collections.Generic;


namespace WebApplication1.Pages.Models
{
  public class OctocatData
  {
    public string Status { get; set; }
    public List<Octocats> Data { get; set; } = new List<Octocats>();
  }
}
