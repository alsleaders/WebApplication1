#pragma checksum "c:\Users\palep\sdg\sandbox\WebApplication1\Pages\Geography.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd36bbba12c05a9472cc9bf4a2c9617dcf12eda9"
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
#line 3 "c:\Users\palep\sdg\sandbox\WebApplication1\Pages\Geography.razor"
using WebApplication1.Pages.Models;

#line default
#line hidden
#line 4 "c:\Users\palep\sdg\sandbox\WebApplication1\Pages\Geography.razor"
using System.Net.Http;

#line default
#line hidden
#line 5 "c:\Users\palep\sdg\sandbox\WebApplication1\Pages\Geography.razor"
using System.Net.Http.Headers;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/geography")]
    public class Geography : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 28 "c:\Users\palep\sdg\sandbox\WebApplication1\Pages\Geography.razor"
       

  public GeographyData GeographyFacts {get; set;} = new GeographyData();

  protected override async Task OnInitAsync()
  {
    GeographyFacts = await Http.GetJsonAsync<GeographyData>("https://opentdb.com/api.php?amount=10&category=22&difficulty=medium&type=multiple");
  }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
