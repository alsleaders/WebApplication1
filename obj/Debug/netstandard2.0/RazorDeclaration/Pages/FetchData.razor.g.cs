#pragma checksum "c:\Users\palep\sdg\sandbox\WebApplication1\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f9d58f3e24bdeeafe03c4f620c3da8d4e374aca"
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
#line 3 "c:\Users\palep\sdg\sandbox\WebApplication1\Pages\FetchData.razor"
using WebApplication1.Pages.Models;

#line default
#line hidden
#line 4 "c:\Users\palep\sdg\sandbox\WebApplication1\Pages\FetchData.razor"
using System.Net.Http;

#line default
#line hidden
#line 5 "c:\Users\palep\sdg\sandbox\WebApplication1\Pages\FetchData.razor"
using System.Net.Http.Headers;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 40 "c:\Users\palep\sdg\sandbox\WebApplication1\Pages\FetchData.razor"
       

    public OctocatData Octocats {get;set;} = new OctocatData();

    protected override async Task OnInitAsync()
    {
        Octocats = await Http.GetJsonAsync<OctocatData>("https://sdg-octodex.herokuapp.com/");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
