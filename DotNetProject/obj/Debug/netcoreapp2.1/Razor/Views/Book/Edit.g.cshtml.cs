#pragma checksum "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Book\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dad1b407bbce4fd042f177c9784fcb5a41b28349"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Edit), @"mvc.1.0.view", @"/Views/Book/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Edit.cshtml", typeof(AspNetCore.Views_Book_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dad1b407bbce4fd042f177c9784fcb5a41b28349", @"/Views/Book/Edit.cshtml")]
    public class Views_Book_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotNetProject.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Book\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(76, 2098, true);
            WriteLiteral(@"
<h2>Edit</h2>

<h4>Book</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""id"" class=""control-label""></label>
                <input asp-for=""id"" class=""form-control"" />
                <span asp-validation-for=""id"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""name"" class=""control-label""></label>
                <input asp-for=""name"" class=""form-control"" />
                <span asp-validation-for=""name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""description"" class=""control-label""></label>
                <input asp-for=""description"" class=""form-control"" />
                <span asp-validation-for=""description"" class=""text-danger""></span>
            </div>
  ");
            WriteLiteral(@"          <div class=""form-group"">
                <label asp-for=""imageUrl"" class=""control-label""></label>
                <input asp-for=""imageUrl"" class=""form-control"" />
                <span asp-validation-for=""imageUrl"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""authorId"" class=""control-label""></label>
                <input asp-for=""authorId"" class=""form-control"" />
                <span asp-validation-for=""authorId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""posterId"" class=""control-label""></label>
                <input asp-for=""posterId"" class=""form-control"" />
                <span asp-validation-for=""posterId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    ");
            WriteLiteral("<a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DotNetProject.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591