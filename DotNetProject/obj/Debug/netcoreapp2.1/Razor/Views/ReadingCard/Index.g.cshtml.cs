#pragma checksum "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\ReadingCard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28a8a48580a6de9ba1f5b0034fb2efd6101beaa9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReadingCard_Index), @"mvc.1.0.view", @"/Views/ReadingCard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ReadingCard/Index.cshtml", typeof(AspNetCore.Views_ReadingCard_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28a8a48580a6de9ba1f5b0034fb2efd6101beaa9", @"/Views/ReadingCard/Index.cshtml")]
    public class Views_ReadingCard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DotNetProject.Models.ReadingCard>>
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\ReadingCard\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(83, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(112, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6364b5d584594dba98100426fdba648a", async() => {
                BeginContext(118, 87, true);
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
            BeginContext(212, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(214, 907, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6437e8479d164e27b86fcb7cd81f28d6", async() => {
                BeginContext(220, 172, true);
                WriteLiteral("\r\n    <p>\r\n        <a asp-action=\"Create\">Create New</a>\r\n    </p>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(393, 40, false);
#line 22 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\ReadingCard\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.user));

#line default
#line hidden
                EndContext();
                BeginContext(433, 106, true);
                WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 28 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\ReadingCard\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(596, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(669, 42, false);
#line 32 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\ReadingCard\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.user.id));

#line default
#line hidden
                EndContext();
                BeginContext(711, 99, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a asp-action=\"Edit\"");
                EndContext();
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 810, "\"", 833, 1);
#line 35 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\ReadingCard\Index.cshtml"
WriteAttributeValue("", 825, item.id, 825, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(834, 60, true);
                WriteLiteral(">Edit</a> |\r\n                        <a asp-action=\"Details\"");
                EndContext();
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 894, "\"", 917, 1);
#line 36 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\ReadingCard\Index.cshtml"
WriteAttributeValue("", 909, item.id, 909, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(918, 62, true);
                WriteLiteral(">Details</a> |\r\n                        <a asp-action=\"Delete\"");
                EndContext();
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 980, "\"", 1003, 1);
#line 37 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\ReadingCard\Index.cshtml"
WriteAttributeValue("", 995, item.id, 995, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1004, 63, true);
                WriteLiteral(">Delete</a>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 40 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\ReadingCard\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(1082, 32, true);
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
            BeginContext(1121, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DotNetProject.Models.ReadingCard>> Html { get; private set; }
    }
}
#pragma warning restore 1591
