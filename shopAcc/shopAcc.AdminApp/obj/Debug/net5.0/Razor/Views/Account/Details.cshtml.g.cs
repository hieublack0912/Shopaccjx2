#pragma checksum "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a724a3466be1a13b176fbce1695a5edc5a2a776"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Details), @"mvc.1.0.view", @"/Views/Account/Details.cshtml")]
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
#line 1 "D:\test\shopAcc\shopAcc.AdminApp\Views\_ViewImports.cshtml"
using shopAcc.AdminApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\test\shopAcc\shopAcc.AdminApp\Views\_ViewImports.cshtml"
using shopAcc.AdminApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a724a3466be1a13b176fbce1695a5edc5a2a776", @"/Views/Account/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c04b1f7d12470500b927911b81a6c1fabca307af", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<shopAcc.ViewModels.Catalog.Accounts.AccountVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
  
    ViewData["Title"] = "Xem chi ti???t account game";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <h1 class=""mt-4"">Xem chi ti???t account</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/"">Trang ch???</a></li>
        <li class=""breadcrumb-item active"">Chi ti???t account</li>
    </ol>
    <div class=""card mb-4"">
        <div class=""card-header"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a724a3466be1a13b176fbce1695a5edc5a2a7764665", async() => {
                WriteLiteral("V??? danh s??ch");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"card-body\">\r\n            <div class=\"col-md-8\">\r\n                <dl class=\"row\">\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 23 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 26 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 29 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 32 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 35 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.ViewCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 38 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayFor(model => model.ViewCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 41 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 44 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 47 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 50 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 53 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 56 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 59 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Reincarnation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 62 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Reincarnation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 65 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Visional));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 68 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Visional));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 71 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.UserNameAcc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 74 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayFor(model => model.UserNameAcc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 77 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.PasswordAcc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 80 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayFor(model => model.PasswordAcc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 83 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.UserCreate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 86 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayFor(model => model.UserCreate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 89 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.IsFeatured));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 92 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayFor(model => model.IsFeatured));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 95 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.ThumbnailImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 98 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayFor(model => model.ThumbnailImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        M??n Ph??i\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 104 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Categories));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n            <div>\r\n                ");
#nullable restore
#line 109 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\Details.cshtml"
           Write(Html.ActionLink("S???a", "Edit", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<shopAcc.ViewModels.Catalog.Accounts.AccountVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
