#pragma checksum "C:\Users\user\Desktop\ChallengeC#\Disney\ChallengeApiRest\Views\Series\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28a093db293a64f3a9ae1a86578deabe06d49d3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Series_Edit), @"mvc.1.0.view", @"/Views/Series/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28a093db293a64f3a9ae1a86578deabe06d49d3c", @"/Views/Series/Edit.cshtml")]
    public class Views_Series_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChallengeApiRest.Entities.Series>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\Desktop\ChallengeC#\Disney\ChallengeApiRest\Views\Series\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Series</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""id"" />
            <div class=""form-group"">
                <label asp-for=""title"" class=""control-label""></label>
                <input asp-for=""title"" class=""form-control"" />
                <span asp-validation-for=""title"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CreationDate"" class=""control-label""></label>
                <input asp-for=""CreationDate"" class=""form-control"" />
                <span asp-validation-for=""CreationDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""calification"" class=""control-label""></label>
                <input asp-for=""calification"" class=""form-control"" />
                <sp");
            WriteLiteral(@"an asp-validation-for=""calification"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\user\Desktop\ChallengeC#\Disney\ChallengeApiRest\Views\Series\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChallengeApiRest.Entities.Series> Html { get; private set; }
    }
}
#pragma warning restore 1591