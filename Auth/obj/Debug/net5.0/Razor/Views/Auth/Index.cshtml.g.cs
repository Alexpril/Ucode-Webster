#pragma checksum "D:\3_Kurs\Auth\Auth\Views\Auth\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3164207e8baf7b9eaefe476fbd78ba8cfaba64e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Index), @"mvc.1.0.view", @"/Views/Auth/Index.cshtml")]
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
#line 1 "D:\3_Kurs\Auth\Auth\Views\_ViewImports.cshtml"
using Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\3_Kurs\Auth\Auth\Views\_ViewImports.cshtml"
using Auth.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\3_Kurs\Auth\Auth\Views\Auth\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3164207e8baf7b9eaefe476fbd78ba8cfaba64e6", @"/Views/Auth/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fb8f74330c935641f8c300e95fc83593ee831a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\3_Kurs\Auth\Auth\Views\Auth\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n");
#nullable restore
#line 10 "D:\3_Kurs\Auth\Auth\Views\Auth\Index.cshtml"
     if (SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <h1 class=""display-4"">Enjoy!</h1>
        <h1><a href=""http://localhost:3000"">EasyPaint</a></h1>
        <img src=""https://3.bp.blogspot.com/-2rcrKlA13ds/W1NtmtCYTiI/AAAAAAAAAgo/6sS8D4JjvvUvd_scZMlehpC5H6MyyDZVQCLcBGAs/s320/Cat%2Benjoy%2Bmassage%2Bso%2Brelaxing%2Bvery%2Bcute%2Bcat%2Bgifs.gif"">
");
#nullable restore
#line 15 "D:\3_Kurs\Auth\Auth\Views\Auth\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"display-4\">Please login to use EasyPaint</h1>\r\n        <img src=\"https://c.tenor.com/_W2FjRBFfkcAAAAM/cat-please.gif\">\r\n");
#nullable restore
#line 20 "D:\3_Kurs\Auth\Auth\Views\Auth\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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
