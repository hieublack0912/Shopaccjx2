#pragma checksum "D:\test\shopAcc\shopAcc.Client\Views\Account\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6ea0e58849e209a0fdf3e06d4c35f618ea6e591"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Category), @"mvc.1.0.view", @"/Views/Account/Category.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6ea0e58849e209a0fdf3e06d4c35f618ea6e591", @"/Views/Account/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f041ee9b7e274a25f0745e872beb598ab6595a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AccountCategoryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\test\shopAcc\shopAcc.Client\Views\Account\Category.cshtml"
  
    ViewData["Title"] = Model.Category.Name;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul class=\"breadcrumb mt-3\">\r\n    <li><a href=\"/\"><localize>Home</localize></a> <span class=\"divider\"> / </span></li>\r\n    <li class=\"ml-1\">");
#nullable restore
#line 10 "D:\test\shopAcc\shopAcc.Client\Views\Account\Category.cshtml"
                Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6ea0e58849e209a0fdf3e06d4c35f618ea6e5916007", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <input name=\"Id\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 487, "\"", 513, 1);
#nullable restore
#line 14 "D:\test\shopAcc\shopAcc.Client\Views\Account\Category.cshtml"
WriteAttributeValue("", 495, Model.Category.Id, 495, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <div class=\"col-md-5 col-sm-12 mt-1\">\r\n            <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 596, "\"", 620, 1);
#nullable restore
#line 16 "D:\test\shopAcc\shopAcc.Client\Views\Account\Category.cshtml"
WriteAttributeValue("", 604, ViewBag.Keyword, 604, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" onchange=""this.form.submit()"" name=""keyword"" class=""form-control"" placeholder=""Nhập tên account muốn tìm kiếm..."" />
        </div>
        <div class=""col-md-5 col-lg-3 col-sm-6 mt-1"">
            <select name=""ValueRange"" onchange=""this.form.submit()"" class=""form-control"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6ea0e58849e209a0fdf3e06d4c35f618ea6e5917456", async() => {
                    WriteLiteral("--Chọn khoảng giá--");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6ea0e58849e209a0fdf3e06d4c35f618ea6e5918708", async() => {
                    WriteLiteral("--0 VNĐ - 500.000 VNĐ--");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6ea0e58849e209a0fdf3e06d4c35f618ea6e5919964", async() => {
                    WriteLiteral("--500.000 VNĐ - 5.000.000 VNĐ--");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6ea0e58849e209a0fdf3e06d4c35f618ea6e59111228", async() => {
                    WriteLiteral("--5.000.000 VNĐ - 20.000.000 VNĐ--");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6ea0e58849e209a0fdf3e06d4c35f618ea6e59112496", async() => {
                    WriteLiteral("--Trên 20.000.000 VNĐ--");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </select>\r\n        </div>\r\n        <div class=\"col-md-4 col-sm-6 mt-1\">\r\n            <button type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1375, "\"", 1440, 5);
                WriteAttributeValue("", 1385, "window.location.href", 1385, 20, true);
                WriteAttributeValue(" ", 1405, "=", 1406, 2, true);
                WriteAttributeValue(" ", 1407, "\'/Categories/", 1408, 14, true);
#nullable restore
#line 28 "D:\test\shopAcc\shopAcc.Client\Views\Account\Category.cshtml"
WriteAttributeValue("", 1421, Model.Category.Id, 1421, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1439, "\'", 1439, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-dark\">Bỏ qua lọc</button>\r\n            <button type=\"button\" onclick=\"window.location.href = \'/Account\'\" class=\"btn btn-success\">Tất cả account</button>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-sm-12\">\r\n        <h1 class=\"text-danger\">");
#nullable restore
#line 35 "D:\test\shopAcc\shopAcc.Client\Views\Account\Category.cshtml"
                           Write(Html.Raw(TempData["Message"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n");
#nullable restore
#line 37 "D:\test\shopAcc\shopAcc.Client\Views\Account\Category.cshtml"
     for (int i = 0; i < Model.Accounts.Items.Count; i++)
    {
        var item = Model.Accounts.Items[i];
        var url = $"/Accounts/{item.Id}";
        var order = $"/Order/Checkout?accountId={item.Id}";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-4 col-sm-6\">\r\n            <div class=\"card__account\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2092, "\"", 2103, 1);
#nullable restore
#line 44 "D:\test\shopAcc\shopAcc.Client\Views\Account\Category.cshtml"
WriteAttributeValue("", 2099, url, 2099, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img class=\"card__account-img\"");
            BeginWriteAttribute("src", " src=\"", 2157, "\"", 2216, 1);
#nullable restore
#line 45 "D:\test\shopAcc\shopAcc.Client\Views\Account\Category.cshtml"
WriteAttributeValue("", 2163, Configuration["BaseAddress"] + item.ThumbnailImage, 2163, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Ảnh Tài khoản\">\r\n                </a>\r\n                <div class=\"card__account-title mt-2\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 48 "D:\test\shopAcc\shopAcc.Client\Views\Account\Category.cshtml"
                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </div>\r\n                <ul class=\"mb-0\">\r\n                    <li class=\"card__account-list\">Chuyển sinh: ");
#nullable restore
#line 51 "D:\test\shopAcc\shopAcc.Client\Views\Account\Category.cshtml"
                                                           Write(item.Reincarnation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 52 "D:\test\shopAcc\shopAcc.Client\Views\Account\Category.cshtml"
                      
                        var x = @item.Price;
                        var y = x.ToString().Length;
                        var price = "".ToString();
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "D:\test\shopAcc\shopAcc.Client\Views\Account\Category.cshtml"
                     if (y > 6)
                    {
                        var z = y - 3;
                        for (var j = y - 3; j > 0; j--)
                        {
                            if (j == (z - 3))
                            {
                                price = '.' + price;
                                z = z - 3;
                            }
                            price = x.ToString()[j - 1] + price;
                        }
                    }
                    else price = x.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"card__account-list text-danger\">Giá: ");
#nullable restore
#line 71 "D:\test\shopAcc\shopAcc.Client\Views\Account\Category.cshtml"
                                                               Write(price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</li>\r\n                </ul>\r\n                <div class=\"card-body\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3449, "\"", 3460, 1);
#nullable restore
#line 74 "D:\test\shopAcc\shopAcc.Client\Views\Account\Category.cshtml"
WriteAttributeValue("", 3456, url, 3456, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__account-link\">Xem Chi tiết</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3529, "\"", 3542, 1);
#nullable restore
#line 75 "D:\test\shopAcc\shopAcc.Client\Views\Account\Category.cshtml"
WriteAttributeValue("", 3536, order, 3536, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__account-link ml-4\">Mua ngay</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 79 "D:\test\shopAcc\shopAcc.Client\Views\Account\Category.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<hr class=\"soft\" />\r\n\r\n");
#nullable restore
#line 83 "D:\test\shopAcc\shopAcc.Client\Views\Account\Category.cshtml"
Write(await Component.InvokeAsync("Pager", Model.Accounts));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br class=\"clr\" />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccountCategoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
