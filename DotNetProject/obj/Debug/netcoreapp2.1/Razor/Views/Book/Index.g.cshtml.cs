#pragma checksum "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3a98b1273eaf3dbbffd89353cece4f619a52c15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Index.cshtml", typeof(AspNetCore.Views_Book_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3a98b1273eaf3dbbffd89353cece4f619a52c15", @"/Views/Book/Index.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DotNetProject.Models.Book>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Book\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(76, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(105, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97c0fa804fdd49ef807e9808c49d7729", async() => {
                BeginContext(111, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(205, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(207, 2083, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5824ccf8e698411093271c01d2ac0c28", async() => {
                BeginContext(213, 172, true);
                WriteLiteral("\r\n    <p>\r\n        <a asp-action=\"Create\">Create New</a>\r\n    </p>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(386, 40, false);
#line 22 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Book\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
                EndContext();
                BeginContext(426, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(494, 47, false);
#line 25 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Book\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.description));

#line default
#line hidden
                EndContext();
                BeginContext(541, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(609, 44, false);
#line 28 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Book\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.imageUrl));

#line default
#line hidden
                EndContext();
                BeginContext(653, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(721, 42, false);
#line 31 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Book\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.genres));

#line default
#line hidden
                EndContext();
                BeginContext(763, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(831, 42, false);
#line 34 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Book\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.author));

#line default
#line hidden
                EndContext();
                BeginContext(873, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(941, 42, false);
#line 37 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Book\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.poster));

#line default
#line hidden
                EndContext();
                BeginContext(983, 106, true);
                WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 43 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Book\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(1146, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1219, 39, false);
#line 47 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Book\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
                EndContext();
                BeginContext(1258, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1338, 46, false);
#line 50 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Book\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.description));

#line default
#line hidden
                EndContext();
                BeginContext(1384, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1464, 43, false);
#line 53 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Book\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.imageUrl));

#line default
#line hidden
                EndContext();
                BeginContext(1507, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1587, 41, false);
#line 56 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Book\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.genres));

#line default
#line hidden
                EndContext();
                BeginContext(1628, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1708, 46, false);
#line 59 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Book\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.author.name));

#line default
#line hidden
                EndContext();
                BeginContext(1754, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1834, 46, false);
#line 62 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Book\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.poster.name));

#line default
#line hidden
                EndContext();
                BeginContext(1880, 99, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a asp-action=\"Edit\"");
                EndContext();
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1979, "\"", 2002, 1);
#line 65 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Book\Index.cshtml"
WriteAttributeValue("", 1994, item.id, 1994, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2003, 60, true);
                WriteLiteral(">Edit</a> |\r\n                        <a asp-action=\"Details\"");
                EndContext();
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2063, "\"", 2086, 1);
#line 66 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Book\Index.cshtml"
WriteAttributeValue("", 2078, item.id, 2078, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2087, 62, true);
                WriteLiteral(">Details</a> |\r\n                        <a asp-action=\"Delete\"");
                EndContext();
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2149, "\"", 2172, 1);
#line 67 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Book\Index.cshtml"
WriteAttributeValue("", 2164, item.id, 2164, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2173, 63, true);
                WriteLiteral(">Delete</a>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 70 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Book\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(2251, 32, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2290, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DotNetProject.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591