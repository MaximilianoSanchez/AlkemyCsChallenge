#pragma checksum "C:\Users\user\Desktop\ChallengeC#\Disney\ChallengeApiRest\Views\Characters\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "830db9afbfe107c62e886e2606ea092205b2e638"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Characters_Index), @"mvc.1.0.view", @"/Views/Characters/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"830db9afbfe107c62e886e2606ea092205b2e638", @"/Views/Characters/Index.cshtml")]
    public class Views_Characters_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ChallengeApiRest.Models.Character>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\Desktop\ChallengeC#\Disney\ChallengeApiRest\Views\Characters\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\user\Desktop\ChallengeC#\Disney\ChallengeApiRest\Views\Characters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\user\Desktop\ChallengeC#\Disney\ChallengeApiRest\Views\Characters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\user\Desktop\ChallengeC#\Disney\ChallengeApiRest\Views\Characters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\user\Desktop\ChallengeC#\Disney\ChallengeApiRest\Views\Characters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\user\Desktop\ChallengeC#\Disney\ChallengeApiRest\Views\Characters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.story));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\user\Desktop\ChallengeC#\Disney\ChallengeApiRest\Views\Characters\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\user\Desktop\ChallengeC#\Disney\ChallengeApiRest\Views\Characters\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\user\Desktop\ChallengeC#\Disney\ChallengeApiRest\Views\Characters\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\user\Desktop\ChallengeC#\Disney\ChallengeApiRest\Views\Characters\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\user\Desktop\ChallengeC#\Disney\ChallengeApiRest\Views\Characters\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\user\Desktop\ChallengeC#\Disney\ChallengeApiRest\Views\Characters\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.story));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1348, "\"", 1371, 1);
#nullable restore
#line 52 "C:\Users\user\Desktop\ChallengeC#\Disney\ChallengeApiRest\Views\Characters\Index.cshtml"
WriteAttributeValue("", 1363, item.id, 1363, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1424, "\"", 1447, 1);
#nullable restore
#line 53 "C:\Users\user\Desktop\ChallengeC#\Disney\ChallengeApiRest\Views\Characters\Index.cshtml"
WriteAttributeValue("", 1439, item.id, 1439, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1502, "\"", 1525, 1);
#nullable restore
#line 54 "C:\Users\user\Desktop\ChallengeC#\Disney\ChallengeApiRest\Views\Characters\Index.cshtml"
WriteAttributeValue("", 1517, item.id, 1517, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "C:\Users\user\Desktop\ChallengeC#\Disney\ChallengeApiRest\Views\Characters\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ChallengeApiRest.Models.Character>> Html { get; private set; }
    }
}
#pragma warning restore 1591
