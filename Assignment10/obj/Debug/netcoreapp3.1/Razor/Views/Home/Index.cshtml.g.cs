#pragma checksum "/Users/benjamindoyle/Desktop/Assignment10/Assignment10/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d70f84bfa49b190b2e2bbdd17e5c486349457e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "/Users/benjamindoyle/Desktop/Assignment10/Assignment10/Views/_ViewImports.cshtml"
using Assignment10;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/benjamindoyle/Desktop/Assignment10/Assignment10/Views/_ViewImports.cshtml"
using Assignment10.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/benjamindoyle/Desktop/Assignment10/Assignment10/Views/_ViewImports.cshtml"
using Assignment10.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d70f84bfa49b190b2e2bbdd17e5c486349457e4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66f5ca0a3f735c692b71208c82da9e4c3eb051c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Assignment10.Infrastructure.PaginationTagHelper __Assignment10_Infrastructure_PaginationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/benjamindoyle/Desktop/Assignment10/Assignment10/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h3>");
#nullable restore
#line 7 "/Users/benjamindoyle/Desktop/Assignment10/Assignment10/Views/Home/Index.cshtml"
Write(ViewBag.Team);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
<table class=""table table-hover table-bordered table-dark"">
    <tr>
        <th>First Name</th>
        <th>M.I.</th>
        <th>Last Name</th>
        <th>Address</th>
        <th>City</th>
        <th>State</th>
        <th>Zip</th>
        <th>Phone</th>
    </tr>
");
#nullable restore
#line 19 "/Users/benjamindoyle/Desktop/Assignment10/Assignment10/Views/Home/Index.cshtml"
     foreach (var x in Model.Bowlers)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 22 "/Users/benjamindoyle/Desktop/Assignment10/Assignment10/Views/Home/Index.cshtml"
           Write(x.BowlerFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 23 "/Users/benjamindoyle/Desktop/Assignment10/Assignment10/Views/Home/Index.cshtml"
           Write(x.BowlerMiddleInit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 24 "/Users/benjamindoyle/Desktop/Assignment10/Assignment10/Views/Home/Index.cshtml"
           Write(x.BowlerLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 25 "/Users/benjamindoyle/Desktop/Assignment10/Assignment10/Views/Home/Index.cshtml"
           Write(x.BowlerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 26 "/Users/benjamindoyle/Desktop/Assignment10/Assignment10/Views/Home/Index.cshtml"
           Write(x.BowlerCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 27 "/Users/benjamindoyle/Desktop/Assignment10/Assignment10/Views/Home/Index.cshtml"
           Write(x.BowlerState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 28 "/Users/benjamindoyle/Desktop/Assignment10/Assignment10/Views/Home/Index.cshtml"
           Write(x.BowlerZip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 29 "/Users/benjamindoyle/Desktop/Assignment10/Assignment10/Views/Home/Index.cshtml"
           Write(x.BowlerPhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \n        </tr>\n");
#nullable restore
#line 31 "/Users/benjamindoyle/Desktop/Assignment10/Assignment10/Views/Home/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d70f84bfa49b190b2e2bbdd17e5c486349457e46310", async() => {
                WriteLiteral("\n\n");
            }
            );
            __Assignment10_Infrastructure_PaginationTagHelper = CreateTagHelper<global::Assignment10.Infrastructure.PaginationTagHelper>();
            __tagHelperExecutionContext.Add(__Assignment10_Infrastructure_PaginationTagHelper);
#nullable restore
#line 34 "/Users/benjamindoyle/Desktop/Assignment10/Assignment10/Views/Home/Index.cshtml"
__Assignment10_Infrastructure_PaginationTagHelper.PageInfo = Model.PageNumberingInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-info", __Assignment10_Infrastructure_PaginationTagHelper.PageInfo, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Assignment10_Infrastructure_PaginationTagHelper.KeyValuePairs == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("page-url-team", "Assignment10.Infrastructure.PaginationTagHelper", "KeyValuePairs"));
            }
#nullable restore
#line 34 "/Users/benjamindoyle/Desktop/Assignment10/Assignment10/Views/Home/Index.cshtml"
__Assignment10_Infrastructure_PaginationTagHelper.KeyValuePairs["team"] = Model.Team;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-team", __Assignment10_Infrastructure_PaginationTagHelper.KeyValuePairs["team"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
