#pragma checksum "c:\Users\palep\sdg\sandbox\WebApplication1\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92a3de9e6662327705668e4aba22d7832e61ed3e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication1.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "c:\Users\palep\sdg\sandbox\WebApplication1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
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
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 33 "c:\Users\palep\sdg\sandbox\WebApplication1\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
