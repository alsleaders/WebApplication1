#pragma checksum "c:\Users\palep\sdg\sandbox\WebApplication1\Pages\FetchAnother.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce021d98dd2d48b7dcc35791708329d47ae52d2c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 2 "c:\Users\palep\sdg\sandbox\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "c:\Users\palep\sdg\sandbox\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "c:\Users\palep\sdg\sandbox\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "c:\Users\palep\sdg\sandbox\WebApplication1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "c:\Users\palep\sdg\sandbox\WebApplication1\_Imports.razor"
using WebApplication1;

#line default
#line hidden
#line 7 "c:\Users\palep\sdg\sandbox\WebApplication1\_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#line 3 "c:\Users\palep\sdg\sandbox\WebApplication1\Pages\FetchAnother.razor"
using System.Net.Http;

#line default
#line hidden
#line 4 "c:\Users\palep\sdg\sandbox\WebApplication1\Pages\FetchAnother.razor"
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
        }
        #pragma warning restore 1998
#line 28 "c:\Users\palep\sdg\sandbox\WebApplication1\Pages\FetchAnother.razor"
       
  const string LINK = "https://www.atlasobscura.com";

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
