#pragma checksum "/Users/cloudsu/Documents/netcore/blazor/WebApplication1/Shared/Age.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b07dbedcfd48871cede8e1a4ac42f8c782ee2910"
// <auto-generated/>
#pragma warning disable 1591
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
    public class Age : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "unit");
            builder.AddMarkupContent(2, "\n    ");
            builder.OpenElement(3, "div");
            builder.AddAttribute(4, "class", "label");
            builder.AddMarkupContent(5, "年龄(");
            builder.AddContent(6, Globals.MinAge);
            builder.AddContent(7, "-");
            builder.AddContent(8, Globals.MaxAge);
            builder.AddContent(9, "):");
            builder.CloseElement();
            builder.AddMarkupContent(10, "\n    ");
            builder.OpenElement(11, "div");
            builder.AddAttribute(12, "class", "labelTarget");
            builder.AddMarkupContent(13, "\n        ");
            builder.OpenElement(14, "input");
            builder.AddAttribute(15, "type", "number");
            builder.AddAttribute(16, "class", inputClass);
            builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(AgeAmt));
            builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AgeAmt = __value, AgeAmt));
            builder.CloseElement();
            builder.AddMarkupContent(19, "年龄\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(20, "\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 12 "/Users/cloudsu/Documents/netcore/blazor/WebApplication1/Shared/Age.razor"
           
    protected override void OnAfterRender()
    {
        Model.Register(()=>{
            base.StateHasChanged();
        });
        base.OnAfterRender();
    }
    protected override void OnInit()
    {
        base.OnInit();
        _age=Model.AgeYears;
    }
    int _age;
    bool ErrorStat=false;
    string inputClass
    {
        get
        {
            return ErrorStat ? "error" : string.Empty;
        }
    }

    int AgeAmt
    {
        get
        {
            return _age;
        }
        set
        {
            if(value != _age)
            {
                _age=value;
                if(value<Globals.MinAge || value >Globals.MaxAge)
                    {
                        ErrorStat=true;
                    }
                    else
                    {
                        ErrorStat=false;
                        Model.AgeYears=value;
                    }
            }
        }
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModel Model { get; set; }
    }
}
#pragma warning restore 1591