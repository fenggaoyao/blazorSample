#pragma checksum "/Users/cloudsu/Documents/netcore/blazor/WebApplication1/Pages/test.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6a15804ec85ca74980a80915666b6cadc5ccca8"
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
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using WebApplication1;
    using WebApplication1.Shared;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/test")]
    public class test : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 21 "/Users/cloudsu/Documents/netcore/blazor/WebApplication1/Pages/test.razor"
            
    private IList<TodoItem> todos=new List<TodoItem>();
    private string newtodo;
    private void Addtodo()
    {
        if(!string.IsNullOrWhiteSpace(newtodo))
        {
            todos.Add(new TodoItem{ Title=newtodo});
        }
    }
        

#line default
#line hidden
    }
}
#pragma warning restore 1591