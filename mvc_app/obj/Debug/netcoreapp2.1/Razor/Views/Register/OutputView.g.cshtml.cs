#pragma checksum "C:\Users\mahm\Desktop\Job Tasks\Task MVC\mvc_app\mvc_app\Views\Register\OutputView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1440de4fc3166bf13c3aca1173f251c007732754"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_OutputView), @"mvc.1.0.view", @"/Views/Register/OutputView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Register/OutputView.cshtml", typeof(AspNetCore.Views_Register_OutputView))]
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
#line 1 "C:\Users\mahm\Desktop\Job Tasks\Task MVC\mvc_app\mvc_app\Views\_ViewImports.cshtml"
using mvc_app;

#line default
#line hidden
#line 2 "C:\Users\mahm\Desktop\Job Tasks\Task MVC\mvc_app\mvc_app\Views\_ViewImports.cshtml"
using mvc_app.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1440de4fc3166bf13c3aca1173f251c007732754", @"/Views/Register/OutputView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b1abf854b28eb3fdf3ad32069409924807a7cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_OutputView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<mvc_app.Models.StudentRegisterationModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InputView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\mahm\Desktop\Job Tasks\Task MVC\mvc_app\mvc_app\Views\Register\OutputView.cshtml"
  
    ViewData["Title"] = "outputView";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(148, 8, true);
            WriteLiteral("<hr />\r\n");
            EndContext();
            BeginContext(156, 171, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5851999583bb4f58b42344f6753b6140", async() => {
                BeginContext(186, 134, true);
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <button type=\"submit\" class=\"btn btn-default \"> Registeration</button>          \r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(327, 480, true);
            WriteLiteral(@"

    <table id=""Tmain""class=""table table-hover"">
        <thead>
            <tr>
                <th onclick=""sortTable(0)"" scope=""col"">#</th>
                <th onclick=""sortTable(1)"" scope=""col"">Name</>
                <th onclick=""sortTable(2)"" scope=""col"">Program</th>
                <th onclick=""sortTable(3)"" scope=""col"">Details</th>
                <th onclick=""sortTable(4)"" scope=""col"">File Name</th>

            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 25 "C:\Users\mahm\Desktop\Job Tasks\Task MVC\mvc_app\mvc_app\Views\Register\OutputView.cshtml"
              int i = 0;
                

#line default
#line hidden
#line 26 "C:\Users\mahm\Desktop\Job Tasks\Task MVC\mvc_app\mvc_app\Views\Register\OutputView.cshtml"
                 foreach (var item in Model)
                {
                    i++;

#line default
#line hidden
            BeginContext(924, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(979, 1, false);
#line 30 "C:\Users\mahm\Desktop\Job Tasks\Task MVC\mvc_app\mvc_app\Views\Register\OutputView.cshtml"
                       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(980, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1016, 9, false);
#line 31 "C:\Users\mahm\Desktop\Job Tasks\Task MVC\mvc_app\mvc_app\Views\Register\OutputView.cshtml"
                       Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(1025, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1061, 12, false);
#line 32 "C:\Users\mahm\Desktop\Job Tasks\Task MVC\mvc_app\mvc_app\Views\Register\OutputView.cshtml"
                       Write(item.program);

#line default
#line hidden
            EndContext();
            BeginContext(1073, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1109, 11, false);
#line 33 "C:\Users\mahm\Desktop\Job Tasks\Task MVC\mvc_app\mvc_app\Views\Register\OutputView.cshtml"
                       Write(item.detail);

#line default
#line hidden
            EndContext();
            BeginContext(1120, 37, true);
            WriteLiteral("</td>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1157, "\"", 1254, 3);
            WriteAttributeValue("", 1167, "location.href=\'", 1167, 15, true);
#line 34 "C:\Users\mahm\Desktop\Job Tasks\Task MVC\mvc_app\mvc_app\Views\Register\OutputView.cshtml"
WriteAttributeValue("", 1182, Url.Action("DownloadFile", "Register",new {filename=  @item.filename}), 1182, 71, false);

#line default
#line hidden
            WriteAttributeValue("", 1253, "\'", 1253, 1, true);
            EndWriteAttribute();
            BeginContext(1255, 3, true);
            WriteLiteral(" />");
            EndContext();
            BeginContext(1259, 13, false);
#line 34 "C:\Users\mahm\Desktop\Job Tasks\Task MVC\mvc_app\mvc_app\Views\Register\OutputView.cshtml"
                                                                                                                              Write(item.filename);

#line default
#line hidden
            EndContext();
            BeginContext(1272, 35, true);
            WriteLiteral("</td>\r\n                    </tr> \r\n");
            EndContext();
#line 36 "C:\Users\mahm\Desktop\Job Tasks\Task MVC\mvc_app\mvc_app\Views\Register\OutputView.cshtml"
                }

#line default
#line hidden
            BeginContext(1341, 3025, true);
            WriteLiteral(@"        </tbody>
    </table>

        <script>
            function sortTable(n) {
                var table, rows, switching, i, x, y, shouldSwitch, dir, switchcount = 0;
                table = document.getElementById(""Tmain"");
                switching = true;
                // Set the sorting direction to ascending:
                dir = ""asc"";
                /* Make a loop that will continue until
                no switching has been done: */
                while (switching) {
                    // Start by saying: no switching is done:
                    switching = false;
                    rows = table.rows;
                    /* Loop through all table rows (except the
                    first, which contains table headers): */
                    for (i = 1; i < (rows.length - 1); i++) {
                        // Start by saying there should be no switching:
                        shouldSwitch = false;
                        /* Get the two elements you want to compar");
            WriteLiteral(@"e,
                        one from current row and one from the next: */
                        x = rows[i].getElementsByTagName(""TD"")[n];
                        y = rows[i + 1].getElementsByTagName(""TD"")[n];
                        
                        /* Check if the two rows should switch place,
                        based on the direction, asc or desc: */
                        if (dir == ""asc"") {
                            if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()) {
                                // If so, mark as a switch and break the loop:
                                shouldSwitch = true;
                                break;
                            }
                        } else if (dir == ""desc"") {
                            if (x.innerHTML.toLowerCase() < y.innerHTML.toLowerCase()) {
                                // If so, mark as a switch and break the loop:
                                shouldSwitch = true;
                             ");
            WriteLiteral(@"   break;
                            }
                        }
                    }
                    if (shouldSwitch) {
                        /* If a switch has been marked, make the switch
                        and mark that a switch has been done: */
                        rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
                        switching = true;
                        // Each time a switch is done, increase this count by 1:
                        switchcount++;
                    } else {
                        /* If no switching has been done AND the direction is ""asc"",
                        set the direction to ""desc"" and run the while loop again. */
                        if (switchcount == 0 && dir == ""asc"") {
                            dir = ""desc"";
                            switching = true;
                        }
                    }
                }
            }
        </script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<mvc_app.Models.StudentRegisterationModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
