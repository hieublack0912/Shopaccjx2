#pragma checksum "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d9ca8807b6c11e3aa30d54c9af820b48b6050b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Detail), @"mvc.1.0.view", @"/Views/Account/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d9ca8807b6c11e3aa30d54c9af820b48b6050b5", @"/Views/Account/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f041ee9b7e274a25f0745e872beb598ab6595a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AccountDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("../Order/Checkout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
  
    ViewData["Title"] = "Chi tiết account";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul class=\"breadcrumb mt-3\">\r\n    <li><a href=\"/\"><localize>Home</localize></a> <span class=\"divider\"> / </span></li>\r\n    <li class=\"ml-1\">");
#nullable restore
#line 10 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
                Write(Model.Account.Categories[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"divider\"> /</span></li>\r\n    <li class=\"active ml-1\">Account #");
#nullable restore
#line 11 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
                                Write(Model.Account.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-sm-6\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 539, "\"", 608, 1);
#nullable restore
#line 16 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
WriteAttributeValue("", 546, Configuration["BaseAddress"] + Model.Account.ThumbnailImage, 546, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 609, "\"", 637, 1);
#nullable restore
#line 16 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
WriteAttributeValue("", 617, Model.Account.Title, 617, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 657, "\"", 725, 1);
#nullable restore
#line 17 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
WriteAttributeValue("", 663, Configuration["BaseAddress"] + Model.Account.ThumbnailImage, 663, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail img-detail-main\"");
            BeginWriteAttribute("alt", " alt=\"", 764, "\"", 790, 1);
#nullable restore
#line 17 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
WriteAttributeValue("", 770, Model.Account.Title, 770, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </a>\r\n        <div class=\"row\">\r\n            <div class=\"col-4\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 886, "\"", 955, 1);
#nullable restore
#line 21 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
WriteAttributeValue("", 893, Configuration["BaseAddress"] + Model.Account.ThumbnailImage, 893, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 956, "\"", 984, 1);
#nullable restore
#line 21 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
WriteAttributeValue("", 964, Model.Account.Title, 964, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1012, "\"", 1080, 1);
#nullable restore
#line 22 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
WriteAttributeValue("", 1018, Configuration["BaseAddress"] + Model.Account.ThumbnailImage, 1018, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail img-detail-main\"");
            BeginWriteAttribute("alt", " alt=\"", 1119, "\"", 1145, 1);
#nullable restore
#line 22 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
WriteAttributeValue("", 1125, Model.Account.Title, 1125, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n            <div class=\"col-4\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1242, "\"", 1311, 1);
#nullable restore
#line 26 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
WriteAttributeValue("", 1249, Configuration["BaseAddress"] + Model.Account.ThumbnailImage, 1249, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1312, "\"", 1340, 1);
#nullable restore
#line 26 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
WriteAttributeValue("", 1320, Model.Account.Title, 1320, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1368, "\"", 1436, 1);
#nullable restore
#line 27 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
WriteAttributeValue("", 1374, Configuration["BaseAddress"] + Model.Account.ThumbnailImage, 1374, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail img-detail-main\"");
            BeginWriteAttribute("alt", " alt=\"", 1475, "\"", 1501, 1);
#nullable restore
#line 27 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
WriteAttributeValue("", 1481, Model.Account.Title, 1481, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n            <div class=\"col-4\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1598, "\"", 1667, 1);
#nullable restore
#line 31 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
WriteAttributeValue("", 1605, Configuration["BaseAddress"] + Model.Account.ThumbnailImage, 1605, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1668, "\"", 1696, 1);
#nullable restore
#line 31 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
WriteAttributeValue("", 1676, Model.Account.Title, 1676, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1724, "\"", 1792, 1);
#nullable restore
#line 32 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
WriteAttributeValue("", 1730, Configuration["BaseAddress"] + Model.Account.ThumbnailImage, 1730, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail img-detail-main\"");
            BeginWriteAttribute("alt", " alt=\"", 1831, "\"", 1857, 1);
#nullable restore
#line 32 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
WriteAttributeValue("", 1837, Model.Account.Title, 1837, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-sm-6\">\r\n        <h3>");
#nullable restore
#line 38 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
       Write(Model.Account.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 39 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
          
            var x = @Model.Account.Price;
            var y = x.ToString().Length;
            var price = "".ToString();
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
         if (y > 6)
        {
            var z = y - 3;
            for (var i = y - 3; i > 0; i--)
            {
                if (i == (z - 3))
                {
                    price = '.' + price;
                    z = z - 3;
                }
                price = x.ToString()[i - 1] + price;
            }
        }
        else price = x.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2 class=\"text-danger\">Giá: ");
#nullable restore
#line 58 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
                                Write(price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</h2>\r\n        <p> Chuyển sinh: ");
#nullable restore
#line 59 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
                    Write(Model.Account.Reincarnation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d9ca8807b6c11e3aa30d54c9af820b48b6050b513280", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"accountId\"");
                BeginWriteAttribute("value", " value=\"", 2777, "\"", 2802, 1);
#nullable restore
#line 61 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
WriteAttributeValue("", 2785, Model.Account.Id, 2785, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <button class=\"btn btn-outline-success\"> Mua Account</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"note\">\r\n    <h1>Chi tiết sản phẩm</h1>\r\n");
#nullable restore
#line 68 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
     if (@Model.Account.Visional > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Cấp hóa cảnh: ");
#nullable restore
#line 70 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
                    Write(Model.Account.Visional);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 71 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 72 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
  Write(Model.Account.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Số lượt xem: ");
#nullable restore
#line 73 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
               Write(Model.Account.ViewCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Ngày đăng bán: ");
#nullable restore
#line 74 "D:\test\shopAcc\shopAcc.Client\Views\Account\Detail.cshtml"
                 Write(Model.Account.DateCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccountDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
