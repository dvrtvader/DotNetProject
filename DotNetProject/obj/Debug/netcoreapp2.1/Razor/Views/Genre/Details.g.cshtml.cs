#pragma checksum "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Genre\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acc20fee0f7ce3345f75870dfb0d7fb0a3794207"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Genre_Details), @"mvc.1.0.view", @"/Views/Genre/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Genre/Details.cshtml", typeof(AspNetCore.Views_Genre_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acc20fee0f7ce3345f75870dfb0d7fb0a3794207", @"/Views/Genre/Details.cshtml")]
    public class Views_Genre_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotNetProject.Models.Genre>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Genre\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(80, 119, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Genre</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(200, 38, false);
#line 14 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Genre\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(238, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(282, 34, false);
#line 17 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Genre\Details.cshtml"
       Write(Html.DisplayFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(316, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(360, 40, false);
#line 20 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Genre\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(400, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(444, 36, false);
#line 23 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Genre\Details.cshtml"
       Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(480, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(528, 68, false);
#line 28 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Genre\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(596, 56, true);
            WriteLiteral(" |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DotNetProject.Models.Genre> Html { get; private set; }
    }
}
#pragma warning restore 1591