#pragma checksum "/Users/cloudsu/Documents/netcore/blazor/WebApplication1/Shared/GenderToggle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b48a0e1c640b79b7001b0727714810bc17c77a4c"
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
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using WebApplication1;
    using WebApplication1.Shared;
    public class GenderToggle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 12 "/Users/cloudsu/Documents/netcore/blazor/WebApplication1/Shared/GenderToggle.razor"
                   
    string ToggleText
    {
        get
        {
            return Model.IsMale ? "男" : "女";
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModel Model { get; set; }
    }
}
#pragma warning restore 1591
