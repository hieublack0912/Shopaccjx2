#pragma checksum "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\AllImage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27506a916933ac8eabaf1cfd9d09515ebcb12b0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_AllImage), @"mvc.1.0.view", @"/Views/Account/AllImage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27506a916933ac8eabaf1cfd9d09515ebcb12b0a", @"/Views/Account/AllImage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c04b1f7d12470500b927911b81a6c1fabca307af", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_AllImage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<shopAcc.ViewModels.Catalog.AccountImages.AccountImageViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\AllImage.cshtml"
  
    ViewData["Title"] = "Danh sách hình ảnh";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <h1 class=""mt-4"">Quản lý ảnh</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/"">Trang chủ</a></li>
        <li class=""breadcrumb-item active"">Danh sách ảnh theo account</li>
    </ol>
    <div class=""card mb-12"">
        <div class=""card-body"">
            <div class=""row"">
");
#nullable restore
#line 18 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\AllImage.cshtml"
                 if (ViewBag.SuccessMsg != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"msgAlert\" class=\"alert alert-success\" role=\"alert\">\r\n                        ");
#nullable restore
#line 21 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\AllImage.cshtml"
                   Write(ViewBag.SuccessMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 23 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\AllImage.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <div class=""table-responsive"">
                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th>
                                Mã ảnh
                            </th>
                            <th>
                                Hình ảnh
                            </th>
                            <th>
                                Tên
                            </th>
                            <th>
                                Hiển thị đại diện
                            </th>
                            <th>
                                Ngày thêm
                            </th>
                            <th>
                                thứ tự
                            </th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 51 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\AllImage.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 55 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\AllImage.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 2178, "\"", 2232, 1);
#nullable restore
#line 58 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\AllImage.cshtml"
WriteAttributeValue("", 2184, Configuration["BaseAddress"] + item.ImagePath, 2184, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-rounded\" width=\"300\" />\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 61 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\AllImage.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Caption));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 64 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\AllImage.cshtml"
                               Write(Html.DisplayFor(modelItem => item.IsDefault));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 67 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\AllImage.cshtml"
                               Write(Html.DisplayFor(modelItem => item.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 70 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\AllImage.cshtml"
                               Write(Html.DisplayFor(modelItem => item.SortOrder));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 73 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\AllImage.cshtml"
                               Write(Html.ActionLink("Xóa", "DeleteImage", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 76 "D:\test\shopAcc\shopAcc.AdminApp\Views\Account\AllImage.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<shopAcc.ViewModels.Catalog.AccountImages.AccountImageViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591