#pragma checksum "D:\test\shopAcc\shopAcc.Client\Views\User\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d2e69148dfb834df0f04ea524028c6e555cdda0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Register), @"mvc.1.0.view", @"/Views/User/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d2e69148dfb834df0f04ea524028c6e555cdda0", @"/Views/User/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f041ee9b7e274a25f0745e872beb598ab6595a2", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\test\shopAcc\shopAcc.Client\Views\User\Register.cshtml"
  
    ViewData["Title"] = "Đăng Ký tài khoản";
    Layout = "~/Views/Shared/_Layout2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""layoutAuthentication"">
    <div id=""layoutAuthentication_content"">
        <main>
            <div class=""container"">
                <div class=""row justify-content-center"">
                    <div class=""col-lg-10"">
                        <div class=""card shadow-lg border-0 rounded-lg mt-5"">
                            <div class=""card-header""><h3 class=""text-center font-weight-light my-4"">Đăng Ký</h3></div>
                            <div class=""card-body"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d2e69148dfb834df0f04ea524028c6e555cdda04744", async() => {
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d2e69148dfb834df0f04ea524028c6e555cdda05038", async() => {
                    WriteLiteral("\r\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 16 "D:\test\shopAcc\shopAcc.Client\Views\User\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    <div class=""form-group"">
                                        <label class=""small mb-1"">Họ</label>
                                        <input class=""form-control"" name=""FirstName"" type=""text"" placeholder=""Ví dụ: Vũ, Nguyễn, ..."" />
                                    </div>
                                    <div class=""form-group"">
                                        <label class=""small mb-1"">Tên</label>
                                        <input class=""form-control"" name=""LastName"" type=""text"" placeholder=""Ví dụ: An"" />
                                    </div>
                                    <div class=""form-group"">
                                        <label class=""small mb-1"">Ngày sinh</label>
                                        <input class=""form-control"" name=""Dob"" type=""date"" placeholder=""mm/dd/yyyy"" />
                                    </div>
                                    <div class=""form-group"">
                  ");
                WriteLiteral(@"                      <label class=""small mb-1"">Email</label>
                                        <input class=""form-control"" name=""Email"" type=""text"" placeholder=""Định dạng abc@xyz.def"" />
                                    </div>
                                    <div class=""form-group"">
                                        <label class=""small mb-1"">Số điện thoại</label>
                                        <input class=""form-control"" name=""PhoneNumber"" type=""number"" placeholder=""Ví dụ: 012345678"" />
                                    </div>
                                    <div class=""form-group"">
                                        <label class=""small mb-1"">Tên đăng nhập</label>
                                        <input class=""form-control"" name=""UserName"" type=""text"" placeholder=""Nhập tài khoản"" />
                                    </div>
                                    <div class=""form-group"">
                                        <label class=""small mb-1"">M");
                WriteLiteral(@"ật khẩu</label>
                                        <input class=""form-control"" name=""Password"" type=""password"" placeholder=""Nhập mật khẩu"" />
                                        <span class=""text-danger"">*Lưu ý: mật khẩu phải bao gôm ít nhất 1 ký tự viết hoa, 1 ký tự thường và 1 ký tự đặc biệt</span>
                                    </div>
                                    <div class=""form-group"">
                                        <label class=""small mb-1"">Nhập lại mật khẩu</label>
                                        <input class=""form-control"" name=""Passwordre"" type=""password"" placeholder=""Nhập lại mật khẩu vừa nhập"" />
                                    </div>
                                    <div class=""auth-form__controls"">
                                        <button class=""btn btn--primary btn-submit-create pr-3 pl-3"">ĐĂNG KÝ</button>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""card-footer text-center"">
                                <div class=""small"">Bạn đã có tài khoản? <a href=""/User/Login"">Đăng nhập</a></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </main>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
