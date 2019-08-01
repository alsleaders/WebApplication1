#pragma checksum "C:\Users\palep\sdg\sandbox\WebApplication1\Pages\FetchAnother.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed4f26ad075b64858ba5dc8a0362e99a8d882b8c"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 2 "C:\Users\palep\sdg\sandbox\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\palep\sdg\sandbox\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "C:\Users\palep\sdg\sandbox\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\palep\sdg\sandbox\WebApplication1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\palep\sdg\sandbox\WebApplication1\_Imports.razor"
using WebApplication1;

#line default
#line hidden
#line 7 "C:\Users\palep\sdg\sandbox\WebApplication1\_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#line 3 "C:\Users\palep\sdg\sandbox\WebApplication1\Pages\FetchAnother.razor"
using System.Net.Http;

#line default
#line hidden
#line 4 "C:\Users\palep\sdg\sandbox\WebApplication1\Pages\FetchAnother.razor"
using System.Net.Http.Headers;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchanother")]
    public class FetchAnother : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h1>Fetching Another API</h1>\r\n\r\n");
#line 10 "C:\Users\palep\sdg\sandbox\WebApplication1\Pages\FetchAnother.razor"
 if (places == null) 
{

#line default
#line hidden
            builder.AddContent(1, "  ");
            builder.AddMarkupContent(2, "<p><em>Loading ...accordion</em></p>\r\n");
#line 13 "C:\Users\palep\sdg\sandbox\WebApplication1\Pages\FetchAnother.razor"
}
else
{

#line default
#line hidden
            builder.AddContent(3, "      ");
            builder.OpenElement(4, "ul");
            builder.AddAttribute(5, "class", "places-list");
            builder.AddMarkupContent(6, "\r\n");
#line 17 "C:\Users\palep\sdg\sandbox\WebApplication1\Pages\FetchAnother.razor"
         foreach (var p in places)
        {

#line default
#line hidden
            builder.AddContent(7, "          ");
            builder.OpenElement(8, "li");
            builder.AddContent(9, "In ");
            builder.AddContent(10, 
#line 19 "C:\Users\palep\sdg\sandbox\WebApplication1\Pages\FetchAnother.razor"
                  p.Location

#line default
#line hidden
            );
            builder.AddContent(11, " you can see ");
            builder.AddContent(12, 
#line 19 "C:\Users\palep\sdg\sandbox\WebApplication1\Pages\FetchAnother.razor"
                                          p.Name

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(13, "\r\n          ");
            builder.OpenElement(14, "li");
            builder.AddContent(15, 
#line 20 "C:\Users\palep\sdg\sandbox\WebApplication1\Pages\FetchAnother.razor"
               p.Description

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(16, "\r\n          ");
            builder.OpenElement(17, "li");
            builder.OpenElement(18, "img");
            builder.AddAttribute(19, "src", 
#line 21 "C:\Users\palep\sdg\sandbox\WebApplication1\Pages\FetchAnother.razor"
                         p.Img

#line default
#line hidden
            );
            builder.CloseElement();
            builder.CloseElement();
            builder.AddMarkupContent(20, " <br>\r\n          ");
            builder.OpenElement(21, "li");
            builder.OpenElement(22, "a");
            builder.AddAttribute(23, "href", 
#line 22 "C:\Users\palep\sdg\sandbox\WebApplication1\Pages\FetchAnother.razor"
                        BuildUrl(p.Path)

#line default
#line hidden
            );
            builder.AddContent(24, "Want to know more?");
            builder.CloseElement();
            builder.CloseElement();
            builder.AddMarkupContent(25, "\r\n          <hr>\r\n");
#line 24 "C:\Users\palep\sdg\sandbox\WebApplication1\Pages\FetchAnother.razor"
        }

#line default
#line hidden
            builder.AddContent(26, "      ");
            builder.CloseElement();
            builder.AddMarkupContent(27, "  \r\n");
#line 26 "C:\Users\palep\sdg\sandbox\WebApplication1\Pages\FetchAnother.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 28 "C:\Users\palep\sdg\sandbox\WebApplication1\Pages\FetchAnother.razor"
       
  const string LINK = "https://www.atlasobscura.com";

  private string BuildUrl(string thing) => $"{LINK}{thing}";

  AOList[] places;

  protected override async Task OnInitAsync()
  {
    places = await Http.GetJsonAsync<AOList[]>("sample-data/atlas.json");
  }

  class AOList
  {
    public string Location { get; set; }

    public string Name { get; set; }

    public string Img { get; set; }

    public string Path { get; set; }

    public string Description { get; set; }
  }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
