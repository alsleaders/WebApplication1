using System.Collections.Generic;


namespace WebApplication1.Pages.Models
{
  public class GeographyData
  {
    public string Status { get; set; }

    public List<GeographyFacts> Results { get; set; } = new List<GeographyFacts>();
  }
}