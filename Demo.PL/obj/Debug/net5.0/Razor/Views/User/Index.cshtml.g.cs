#pragma checksum "D:\fullStack\Back-end\assignment\assignment25\MVCproject\Demo.PL\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b56bc992ea769e75c5e44ef14d4a3221615dada"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "D:\fullStack\Back-end\assignment\assignment25\MVCproject\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\fullStack\Back-end\assignment\assignment25\MVCproject\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\fullStack\Back-end\assignment\assignment25\MVCproject\Demo.PL\Views\_ViewImports.cshtml"
using Demo.DAL.Entites;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\fullStack\Back-end\assignment\assignment25\MVCproject\Demo.PL\Views\_ViewImports.cshtml"
using Demo.BLL.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\fullStack\Back-end\assignment\assignment25\MVCproject\Demo.PL\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b56bc992ea769e75c5e44ef14d4a3221615dada", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fd890b38725cb3a070cfd1a726ef413ee3a52a4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("my-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonsPartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\fullStack\Back-end\assignment\assignment25\MVCproject\Demo.PL\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h1>All Users</h1>\r\n    <br />\r\n    <br />\r\n    <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b56bc992ea769e75c5e44ef14d4a3221615dada5283", async() => {
                WriteLiteral(@"
        <div class=""row justify-content-center"">
            <div class=""col-8 "">
                <input type=""text"" class=""form-control"" name=""SearchValue"" placeholder=""Search by Email""/>
            </div>
            <div class=""col-2 "">
                <input type=""submit"" value=""Search"" class=""btn btn-success"" />
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 21 "D:\fullStack\Back-end\assignment\assignment25\MVCproject\Demo.PL\Views\User\Index.cshtml"
     if (Model.Count() > 0 && ViewBag.NoUser == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table table-striped table-hover\">\r\n            <thead>\r\n                <tr>\r\n                    <th>");
#nullable restore
#line 26 "D:\fullStack\Back-end\assignment\assignment25\MVCproject\Demo.PL\Views\User\Index.cshtml"
                   Write(Html.DisplayNameFor(U => U.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                    <th>");
#nullable restore
#line 27 "D:\fullStack\Back-end\assignment\assignment25\MVCproject\Demo.PL\Views\User\Index.cshtml"
                   Write(Html.DisplayNameFor(U => U.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                    <th>");
#nullable restore
#line 28 "D:\fullStack\Back-end\assignment\assignment25\MVCproject\Demo.PL\Views\User\Index.cshtml"
                   Write(Html.DisplayNameFor(U => U.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                    <th>");
#nullable restore
#line 29 "D:\fullStack\Back-end\assignment\assignment25\MVCproject\Demo.PL\Views\User\Index.cshtml"
                   Write(Html.DisplayNameFor(U => U.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                    \r\n                    <th>Details </th>\r\n                    <th>Update </th>\r\n                    <th>Delete </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 37 "D:\fullStack\Back-end\assignment\assignment25\MVCproject\Demo.PL\Views\User\Index.cshtml"
                 foreach (var user in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 40 "D:\fullStack\Back-end\assignment\assignment25\MVCproject\Demo.PL\Views\User\Index.cshtml"
                       Write(Html.DisplayFor(M=> user.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "D:\fullStack\Back-end\assignment\assignment25\MVCproject\Demo.PL\Views\User\Index.cshtml"
                       Write(Html.DisplayFor(M=>user.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "D:\fullStack\Back-end\assignment\assignment25\MVCproject\Demo.PL\Views\User\Index.cshtml"
                       Write(Html.DisplayFor(M=>user.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 43 "D:\fullStack\Back-end\assignment\assignment25\MVCproject\Demo.PL\Views\User\Index.cshtml"
                       Write(Html.DisplayFor(M=>user.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9b56bc992ea769e75c5e44ef14d4a3221615dada10493", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 44 "D:\fullStack\Back-end\assignment\assignment25\MVCproject\Demo.PL\Views\User\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = user.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 47 "D:\fullStack\Back-end\assignment\assignment25\MVCproject\Demo.PL\Views\User\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 50 "D:\fullStack\Back-end\assignment\assignment25\MVCproject\Demo.PL\Views\User\Index.cshtml"

    }
    else if (ViewBag.NoUser != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"mt-5 alert alert-warning\">\r\n            <h3>");
#nullable restore
#line 55 "D:\fullStack\Back-end\assignment\assignment25\MVCproject\Demo.PL\Views\User\Index.cshtml"
           Write(ViewBag.NoUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n");
#nullable restore
#line 57 "D:\fullStack\Back-end\assignment\assignment25\MVCproject\Demo.PL\Views\User\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"mt-5 alert alert-warning\">\r\n            <h3>There is No User</h3>\r\n        </div>\r\n");
#nullable restore
#line 63 "D:\fullStack\Back-end\assignment\assignment25\MVCproject\Demo.PL\Views\User\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
