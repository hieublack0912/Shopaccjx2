#pragma checksum "D:\test\shopAcc\shopAcc.Client\Views\Shared\Components\Balance\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55383f6bd29711cd33f63198ed7f4c15285cf6a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Balance_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Balance/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55383f6bd29711cd33f63198ed7f4c15285cf6a4", @"/Views/Shared/Components/Balance/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f041ee9b7e274a25f0745e872beb598ab6595a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Balance_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<shopAcc.ViewModels.Catalog.AccountBalances.BalanceVm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\test\shopAcc\shopAcc.Client\Views\Shared\Components\Balance\Default.cshtml"
 foreach (var item in Model)
{
    var a = @User.Identity.Name;
    var b = @item.UserName;

    if (a == b)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"log_list-item text-light\">\r\n");
#nullable restore
#line 11 "D:\test\shopAcc\shopAcc.Client\Views\Shared\Components\Balance\Default.cshtml"
              
                var x = @item.Balance;
                var y = x.ToString().Length;
                var price = "".ToString();
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\test\shopAcc\shopAcc.Client\Views\Shared\Components\Balance\Default.cshtml"
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
            WriteLiteral("            S??? d?? ");
#nullable restore
#line 30 "D:\test\shopAcc\shopAcc.Client\Views\Shared\Components\Balance\Default.cshtml"
             Write(price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VN??\r\n        </a>\r\n");
#nullable restore
#line 32 "D:\test\shopAcc\shopAcc.Client\Views\Shared\Components\Balance\Default.cshtml"
    }
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<shopAcc.ViewModels.Catalog.AccountBalances.BalanceVm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
