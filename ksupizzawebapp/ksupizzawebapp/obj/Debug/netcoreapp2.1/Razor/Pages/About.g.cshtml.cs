#pragma checksum "C:\Projects\ksupizzawebapp\ksupizzawebapp\ksupizzawebapp\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a6f0afb073a9cc0a01e393a9a71b60e68d9a384"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ksupizzawebapp.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/About.cshtml", typeof(ksupizzawebapp.Pages.Pages_About), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a6f0afb073a9cc0a01e393a9a71b60e68d9a384", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b058b57c8052fdff46e0ab97191e2729d623d00b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Projects\ksupizzawebapp\ksupizzawebapp\ksupizzawebapp\Pages\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(67, 254, true);
            WriteLiteral("<div class=\"row\">\r\n\r\n\r\n    <header class=\"col-lg-12 col-md-12 col-sm-12 col-xs-12\">\r\n        <h3>\r\n            payment set up page\r\n        </h3>\r\n    </header>\r\n\r\n    <div class=\"col-lg-6 col-md-6 col-sm-12 col-xs-12\" style=\"text-align:left;\">\r\n        ");
            EndContext();
            BeginContext(321, 1123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1696ef1b0ee4c19915ff465f5976726", async() => {
                BeginContext(341, 1096, true);
                WriteLiteral(@"

            <h4>card number</h4>
            <input type=""text"" name="""" value="""" placeholder="""" /><br />
            <h4>card Type</h4>
            <input type=""text"" name=""CompanyName"" value="""" /><br />
            <h4>Name on the card</h4>
            <input type=""text"" name=""CompanyName"" value="""" /><br />
            <table>

                <tr>
                    <td style=""width:70%"">
                        <h4>Expreation date</h4>
                        <input type=""text"" name=""ContactName"" value="""" style=""width:100%"" />
                    </td>

                    <td>
                        <h4>CVC</h4>
                        <input type=""text"" name=""ContactName"" value="""" style=""width:100%"" />
                    </td>
                </tr>
            </table>

           
            <img src=""https://www.bing.com/th/id/OIP.-fRzc79XooFc4qm_bcdEzgHaCX?w=299&h=96&c=7&o=5&pid=1.7"" /><br />
         

            <input type=""submit"" value=""add"" class=""submit"" />
  ");
                WriteLiteral("          <input type=\"submit\" value=\"clear\" class=\"submit\" />\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1444, 121, true);
            WriteLiteral("\r\n     \r\n\r\n    </div>\r\n        <div class=\"col-lg-6 col-md-6 col-sm-12 col-xs-12\" style=\"padding-top:25%;\">\r\n            ");
            EndContext();
            BeginContext(1565, 169, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8016ec547f26429ca62ea846150b8f6a", async() => {
                BeginContext(1585, 142, true);
                WriteLiteral("\r\n\r\n               \r\n\r\n              \r\n                <input type=\"submit\" value=\"continue\" style=\"width:80%\" class=\"submit\" />\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1734, 1640, true);
            WriteLiteral(@"

        </div>
      







    </div>

<style>
    .row {
        margin: 0%;
        padding: 0%;
        height: 650px;
        width: 100%;
        border: 1px solid lightgray;
        margin-top: 150px;
        background-color: white;
        border: 1px solid lightgray;
        -moz-box-shadow: 2px 2px 2px 2px darkblue;
        -webkit-box-shadow: 2px 2px 2px 2px darkblue;
        box-shadow: 0px 0px 10px 0px gray;
    }

    header {
        height: 60px;
        border-bottom: 1px solid lightgray;
        background-color: #febc11;
        font-weight: bold;
    }

    footer {
        height: 60px;
        border-top: 1px solid lightgray;
    }

        footer h3 {
            float: right;
            margin-right: 40px;
        }

    h3 {
        text-align: center;
        text-transform: capitalize;
    }

    .row div {
        margin: 0%;
        /*border: 1px solid lightgray;*/
        vertical-align: central;
        display: inline-b");
            WriteLiteral(@"lock;
        padding: 5%;
    }

    input {
        height: 50px;
        width: 100%;
        padding-left: 5%;
        padding-right: 5%;
        border: 1px solid lightgray;
    }

    form {
        padding: 0%;
        width: 100%;
    }

    .submit {
        background-color: black;
        color: #febc11;
        font-weight:bold;
        width: 49%;
        margin: 0%;
        display: inline;
    }

    #formCheck input {
        width: 100%;
    }

    h4 {
        text-transform: uppercase;
    }
    img{
        height:80px;
        
        
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutModel>)PageContext?.ViewData;
        public AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
