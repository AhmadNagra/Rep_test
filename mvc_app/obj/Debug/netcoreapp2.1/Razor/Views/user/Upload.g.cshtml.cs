#pragma checksum "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\Upload.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15836f5611987a2b76be3b07cc0c27beedbded29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_user_Upload), @"mvc.1.0.view", @"/Views/user/Upload.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/user/Upload.cshtml", typeof(AspNetCore.Views_user_Upload))]
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
#line 1 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\_ViewImports.cshtml"
using mvc_app;

#line default
#line hidden
#line 2 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\_ViewImports.cshtml"
using mvc_app.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15836f5611987a2b76be3b07cc0c27beedbded29", @"/Views/user/Upload.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b1abf854b28eb3fdf3ad32069409924807a7cf", @"/Views/_ViewImports.cshtml")]
    public class Views_user_Upload : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<mvc_app.Models.UserModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\Upload.cshtml"
  
    ViewData["Title"] = "Upload";

#line default
#line hidden
            BeginContext(75, 76, true);
            WriteLiteral("<input type=\"button\" class=\"btn-primary\" style=\"float:right;\" value=\"Create\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 151, "\"", 208, 3);
            WriteAttributeValue("", 161, "location.href=\'", 161, 15, true);
#line 5 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\Upload.cshtml"
WriteAttributeValue("", 176, Url.Action("userpage", "User"), 176, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 207, "\'", 207, 1, true);
            EndWriteAttribute();
            BeginContext(209, 395, true);
            WriteLiteral(@" />
<div><h3>Users Data</h3></div>
<table class=""table table-striped table-bordered"">
    <thead>
        <tr>

            <th scope=""col"">Name</th>
            <th scope=""col"">Email</th>
            <th scope=""col"">Comments</th>
            <th scope=""col"">Choices</th>
            <th scope=""col"">File</th>
        </tr>
    </thead>
    <tbody>
        <tr>

            <td>");
            EndContext();
            BeginContext(605, 10, false);
#line 21 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\Upload.cshtml"
           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(615, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(639, 11, false);
#line 22 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\Upload.cshtml"
           Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(650, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(674, 14, false);
#line 23 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\Upload.cshtml"
           Write(Model.Comments);

#line default
#line hidden
            EndContext();
            BeginContext(688, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(712, 12, false);
#line 24 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\Upload.cshtml"
           Write(Model.Choice);

#line default
#line hidden
            EndContext();
            BeginContext(724, 25, true);
            WriteLiteral("</td>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 749, "\"", 839, 2);
#line 25 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\Upload.cshtml"
WriteAttributeValue("", 756, Url.Action("DownloadDiffFiles", "user", new {FileToDownload =  @Model.FileNames}), 756, 82, false);

#line default
#line hidden
            WriteAttributeValue(" ", 838, "", 839, 1, true);
            EndWriteAttribute();
            BeginContext(840, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(842, 15, false);
#line 25 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\Upload.cshtml"
                                                                                                         Write(Model.FileNames);

#line default
#line hidden
            EndContext();
            BeginContext(857, 136, true);
            WriteLiteral("</a></td>\r\n\r\n\r\n\r\n        </tr>\r\n\r\n    </tbody>\r\n</table>\r\n\r\n<input type=\"button\" class=\"btn-primary\" style=\"float:right;\" value=\"Create\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 993, "\"", 1050, 3);
            WriteAttributeValue("", 1003, "location.href=\'", 1003, 15, true);
#line 34 "C:\Users\saar\Downloads\pro1\mvc_app\mvc_app\Views\user\Upload.cshtml"
WriteAttributeValue("", 1018, Url.Action("ShowData", "User"), 1018, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 1049, "\'", 1049, 1, true);
            EndWriteAttribute();
            BeginContext(1051, 11, true);
            WriteLiteral(" />\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mvc_app.Models.UserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591