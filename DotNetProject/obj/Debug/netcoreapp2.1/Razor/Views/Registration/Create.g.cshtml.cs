#pragma checksum "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Registration\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daa148a726ea472c1739019408fecbf8c2a11e5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registration_Create), @"mvc.1.0.view", @"/Views/Registration/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Registration/Create.cshtml", typeof(AspNetCore.Views_Registration_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daa148a726ea472c1739019408fecbf8c2a11e5e", @"/Views/Registration/Create.cshtml")]
    public class Views_Registration_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotNetProject.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\aidok\source\repos\DotNetProject\DotNetProject\Views\Registration\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(78, 1821, true);
            WriteLiteral(@"
<h2>Create</h2>

<h4>User</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
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
                <label asp-for=""email"" class=""control-label""></label>
                <input asp-for=""email"" class=""form-control"" />
                <span asp-validation-for=""email"" class=""text-danger""></span>
            </div>
            <div");
            WriteLiteral(@" class=""form-group"">
                <label asp-for=""password"" class=""control-label""></label>
                <input asp-for=""password"" class=""form-control"" />
                <span asp-validation-for=""password"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""readingCardId"" class=""control-label""></label>
                <input asp-for=""readingCardId"" class=""form-control"" />
                <span asp-validation-for=""readingCardId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DotNetProject.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
