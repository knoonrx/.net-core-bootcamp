#pragma checksum "C:\Users\knoonrx\source\repos\FirstApplication\FirstApplication\Views\Music\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f21bbce9675ed5bea9fdf023fd8f687ef86b813f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Music_Index), @"mvc.1.0.view", @"/Views/Music/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Music/Index.cshtml", typeof(AspNetCore.Views_Music_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f21bbce9675ed5bea9fdf023fd8f687ef86b813f", @"/Views/Music/Index.cshtml")]
    public class Views_Music_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FirstApplication.Models.Band>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\knoonrx\source\repos\FirstApplication\FirstApplication\Views\Music\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(140, 158, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(299, 41, false);
#line 17 "C:\Users\knoonrx\source\repos\FirstApplication\FirstApplication\Views\Music\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(340, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(396, 41, false);
#line 20 "C:\Users\knoonrx\source\repos\FirstApplication\FirstApplication\Views\Music\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(437, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(493, 42, false);
#line 23 "C:\Users\knoonrx\source\repos\FirstApplication\FirstApplication\Views\Music\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Origin));

#line default
#line hidden
            EndContext();
            BeginContext(535, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(591, 45, false);
#line 26 "C:\Users\knoonrx\source\repos\FirstApplication\FirstApplication\Views\Music\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Biography));

#line default
#line hidden
            EndContext();
            BeginContext(636, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "C:\Users\knoonrx\source\repos\FirstApplication\FirstApplication\Views\Music\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(754, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(803, 40, false);
#line 35 "C:\Users\knoonrx\source\repos\FirstApplication\FirstApplication\Views\Music\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(843, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(899, 40, false);
#line 38 "C:\Users\knoonrx\source\repos\FirstApplication\FirstApplication\Views\Music\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(939, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(995, 41, false);
#line 41 "C:\Users\knoonrx\source\repos\FirstApplication\FirstApplication\Views\Music\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Origin));

#line default
#line hidden
            EndContext();
            BeginContext(1036, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1092, 44, false);
#line 44 "C:\Users\knoonrx\source\repos\FirstApplication\FirstApplication\Views\Music\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Biography));

#line default
#line hidden
            EndContext();
            BeginContext(1136, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1192, 65, false);
#line 47 "C:\Users\knoonrx\source\repos\FirstApplication\FirstApplication\Views\Music\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1257, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1278, 71, false);
#line 48 "C:\Users\knoonrx\source\repos\FirstApplication\FirstApplication\Views\Music\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1349, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1370, 69, false);
#line 49 "C:\Users\knoonrx\source\repos\FirstApplication\FirstApplication\Views\Music\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1439, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 52 "C:\Users\knoonrx\source\repos\FirstApplication\FirstApplication\Views\Music\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1478, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FirstApplication.Models.Band>> Html { get; private set; }
    }
}
#pragma warning restore 1591
