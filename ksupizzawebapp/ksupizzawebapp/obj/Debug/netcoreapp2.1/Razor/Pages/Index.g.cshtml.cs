#pragma checksum "C:\Projects\ksupizzawebapp\ksupizzawebapp\ksupizzawebapp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f9ceb224b5122c27a9c07d6f70dcff39ac8eb23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ksupizzawebapp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(ksupizzawebapp.Pages.Pages_Index), null)]
namespace ksupizzawebapp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Projects\ksupizzawebapp\ksupizzawebapp\ksupizzawebapp\Pages\_ViewImports.cshtml"
using ksupizzawebapp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f9ceb224b5122c27a9c07d6f70dcff39ac8eb23", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b058b57c8052fdff46e0ab97191e2729d623d00b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 162, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<div class=\"row\">\r\n\r\n    <header class=\"col-lg-12 col-md-12 col-sm-12 col-xs-12\">\r\n        <h3>\r\n            online menu\r\n        </h3>\r\n    </header>\r\n");
            EndContext();
#line 15 "C:\Projects\ksupizzawebapp\ksupizzawebapp\ksupizzawebapp\Pages\Index.cshtml"
     foreach (var r in Model.menulist)
    {



#line default
#line hidden
            BeginContext(238, 247, true);
            WriteLiteral("        <div id=\"menu\" class=\"col-lg-3 col-md-3 col-sm-3 col-xs-12\" style=\"background-color:black; overflow:\">\r\n\r\n            <fieldset>\r\n\r\n                <div style=\"height:180px; width:100%; border:1px solid red;\">\r\n\r\n\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 485, "\"", 522, 1);
#line 26 "C:\Projects\ksupizzawebapp\ksupizzawebapp\ksupizzawebapp\Pages\Index.cshtml"
WriteAttributeValue("", 491, Url.Content(r.ImageReferaceId), 491, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(523, 9, true);
            WriteLiteral(" />\r\n\r\n\r\n");
            EndContext();
            BeginContext(21585, 126, true);
            WriteLiteral("                </div>\r\n                <div>\r\n                    <label for=\"\">Pizza Name:</label>\r\n                </div>\r\n");
            EndContext();
            BeginContext(21840, 45, true);
            WriteLiteral("\r\n            </fieldset>\r\n\r\n        </div>\r\n");
            EndContext();
#line 41 "C:\Projects\ksupizzawebapp\ksupizzawebapp\ksupizzawebapp\Pages\Index.cshtml"




    }

#line default
#line hidden
            BeginContext(21900, 1265, true);
            WriteLiteral(@"    <div>

        <input type=""button"" class=""submit"" value=""place order"" />
    </div>

    <hr />
</div>


<style>
    .row {
        margin: 0%;
        padding: 0%;
        height: 650px;
        width: 100%;
        margin-top: 100px;
        border: 1px solid lightgray;
        -moz-box-shadow: 2px 2px 2px 2px darkblue;
        -webkit-box-shadow: 2px 2px 2px 2px darkblue;
        box-shadow: 0px 0px 10px 0px gray;
        /*background-color:black;*/
    }

    form div {
        text-align: center;
    }

    row {
        padding: 0%;
        height: 650px;
    }

    header {
        background-color: #febc11;
        font-weight: bold;
    }

    #menu {
        margin: 0%;
        padding: 1%;
        height: 300px;
    }

    form {
        border: 1px solid lightgray;
    }

    img {
        width: 99%;
        height: auto;
    }

    .submit {
        background-color: black;
        border-radius: 2%;
        border: 1px solid gray;
   ");
            WriteLiteral("     color: #febc11;\r\n        font-weight: bold;\r\n        height: 40px;\r\n        width: 50%;\r\n        margin: 0%;\r\n        display: inline;\r\n    }\r\n\r\n        .submit:active {\r\n            background-color: darkslategray;\r\n        }\r\n</style>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MenuModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MenuModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MenuModel>)PageContext?.ViewData;
        public MenuModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
