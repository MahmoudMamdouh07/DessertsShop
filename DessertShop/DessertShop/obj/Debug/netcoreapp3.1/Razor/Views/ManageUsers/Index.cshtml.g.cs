#pragma checksum "C:\Users\mahmo\Documents\GitHub\DesertShop\DessertShop\DessertShop\Views\ManageUsers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4312ec6ee8c4c794a5d1ae3f9e8ed6549bf7a94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManageUsers_Index), @"mvc.1.0.view", @"/Views/ManageUsers/Index.cshtml")]
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
#line 1 "C:\Users\mahmo\Documents\GitHub\DesertShop\DessertShop\DessertShop\Views\_ViewImports.cshtml"
using DessertShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mahmo\Documents\GitHub\DesertShop\DessertShop\DessertShop\Views\_ViewImports.cshtml"
using DessertShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mahmo\Documents\GitHub\DesertShop\DessertShop\DessertShop\Views\_ViewImports.cshtml"
using DessertShop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4312ec6ee8c4c794a5d1ae3f9e8ed6549bf7a94", @"/Views/ManageUsers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05a0c4d7e1329c383a0377f0f8af572e76b2035b", @"/Views/_ViewImports.cshtml")]
    public class Views_ManageUsers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ManageUsersViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mahmo\Documents\GitHub\DesertShop\DessertShop\DessertShop\Views\ManageUsers\Index.cshtml"
  
    ViewData["Title"] = "Manage users";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "C:\Users\mahmo\Documents\GitHub\DesertShop\DessertShop\DessertShop\Views\ManageUsers\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<h3>Administrators</h3>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <td>Id</td>\r\n            <td>Email</td>\r\n        </tr>\r\n    </thead>\r\n\r\n");
#nullable restore
#line 19 "C:\Users\mahmo\Documents\GitHub\DesertShop\DessertShop\DessertShop\Views\ManageUsers\Index.cshtml"
     foreach (var user in Model.Administrators)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\mahmo\Documents\GitHub\DesertShop\DessertShop\DessertShop\Views\ManageUsers\Index.cshtml"
           Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\mahmo\Documents\GitHub\DesertShop\DessertShop\DessertShop\Views\ManageUsers\Index.cshtml"
           Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 25 "C:\Users\mahmo\Documents\GitHub\DesertShop\DessertShop\DessertShop\Views\ManageUsers\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<h3>Everyone</h3>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <td>Id</td>\r\n            <td>Email</td>\r\n        </tr>\r\n    </thead>\r\n\r\n");
#nullable restore
#line 38 "C:\Users\mahmo\Documents\GitHub\DesertShop\DessertShop\DessertShop\Views\ManageUsers\Index.cshtml"
     foreach (var user in Model.Everyone)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 41 "C:\Users\mahmo\Documents\GitHub\DesertShop\DessertShop\DessertShop\Views\ManageUsers\Index.cshtml"
           Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 42 "C:\Users\mahmo\Documents\GitHub\DesertShop\DessertShop\DessertShop\Views\ManageUsers\Index.cshtml"
           Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 44 "C:\Users\mahmo\Documents\GitHub\DesertShop\DessertShop\DessertShop\Views\ManageUsers\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ManageUsersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591