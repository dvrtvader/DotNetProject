#pragma checksum "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\ReadingCard\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d4711754643ffa52358f0e578c0bad9015dc7b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReadingCard_Delete), @"mvc.1.0.view", @"/Views/ReadingCard/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ReadingCard/Delete.cshtml", typeof(AspNetCore.Views_ReadingCard_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d4711754643ffa52358f0e578c0bad9015dc7b0", @"/Views/ReadingCard/Delete.cshtml")]
    public class Views_ReadingCard_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotNetProject.Models.ReadingCard>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\ReadingCard\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(85, 172, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>ReadingCard</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(258, 38, false);
#line 15 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\ReadingCard\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(296, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(340, 34, false);
#line 18 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\ReadingCard\Delete.cshtml"
       Write(Html.DisplayFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(374, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(418, 42, false);
#line 21 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\ReadingCard\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.userId));

#line default
#line hidden
            EndContext();
            BeginContext(460, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(504, 38, false);
#line 24 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\ReadingCard\Delete.cshtml"
       Write(Html.DisplayFor(model => model.userId));

#line default
#line hidden
            EndContext();
            BeginContext(542, 209, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    <form asp-action=\"Delete\">\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        <a asp-action=\"Index\">Back to List</a>\r\n    </form>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DotNetProject.Models.ReadingCard> Html { get; private set; }
    }
}
#pragma warning restore 1591
