#pragma checksum "D:\test\shopAcc\shopAcc.Client\Views\User\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63a214a8c849c7e4d63b8ed6d177d2dfba4207d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Details), @"mvc.1.0.view", @"/Views/User/Details.cshtml")]
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
#line 1 "D:\test\shopAcc\shopAcc.Client\Views\_ViewImports.cshtml"
using shopAcc.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\test\shopAcc\shopAcc.Client\Views\_ViewImports.cshtml"
using shopAcc.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63a214a8c849c7e4d63b8ed6d177d2dfba4207d2", @"/Views/User/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f041ee9b7e274a25f0745e872beb598ab6595a2", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<shopAcc.ViewModels.System.Users.UserVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/changepass"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn--primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\test\shopAcc\shopAcc.Client\Views\User\Details.cshtml"
   ViewData["Title"] = "Chi tiết";
    Layout = "~/Views/Shared/_Layout2.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <ul class=""breadcrumb mt-3"">
        <li><a href=""/""><localize>Home</localize></a> <span class=""divider""> / </span></li>
        <li class=""active ml-1"">Thông tin tài khoản</li>
    </ul>
    <h1 class=""text-light bg-success pl-2"">");
#nullable restore
#line 11 "D:\test\shopAcc\shopAcc.Client\Views\User\Details.cshtml"
                                      Write(Html.Raw(TempData["Message"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
    <div class=""card mb-4"">
        <div class=""card-body"">
            <div class=""col-md-12"">
                <dl class=""row"">
                    <dt class=""col-sm-2"">
                        Họ Tên
                    </dt>
                    <dd class=""col-sm-10"">
                        ");
#nullable restore
#line 20 "D:\test\shopAcc\shopAcc.Client\Views\User\Details.cshtml"
                   Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 21 "D:\test\shopAcc\shopAcc.Client\Views\User\Details.cshtml"
                   Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        Số điện thoại\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
#nullable restore
#line 27 "D:\test\shopAcc\shopAcc.Client\Views\User\Details.cshtml"
                   Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        Tên đăng nhập\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
#nullable restore
#line 33 "D:\test\shopAcc\shopAcc.Client\Views\User\Details.cshtml"
                   Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        Địa chỉ Email\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
#nullable restore
#line 39 "D:\test\shopAcc\shopAcc.Client\Views\User\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt class=\"col-sm-2\">\n                        Ngày sinh\n                    </dt>\n                    <dd class=\"col-sm-10\">\n                        ");
#nullable restore
#line 45 "D:\test\shopAcc\shopAcc.Client\Views\User\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Dob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                </dl>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63a214a8c849c7e4d63b8ed6d177d2dfba4207d27929", async() => {
                WriteLiteral("Thay đổi thông tin");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63a214a8c849c7e4d63b8ed6d177d2dfba4207d29113", async() => {
                WriteLiteral("Đổi mật khẩu");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<shopAcc.ViewModels.System.Users.UserVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
