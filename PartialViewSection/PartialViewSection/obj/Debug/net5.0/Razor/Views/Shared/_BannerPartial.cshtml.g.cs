#pragma checksum "D:\Code Academy\Teaching\Groupes\P222\Lessons\68.09.12.2021\Codes\PartialViewSection\PartialViewSection\Views\Shared\_BannerPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baa13ef8afc197c91f7c69625aaf257d4351393b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BannerPartial), @"mvc.1.0.view", @"/Views/Shared/_BannerPartial.cshtml")]
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
#line 1 "D:\Code Academy\Teaching\Groupes\P222\Lessons\68.09.12.2021\Codes\PartialViewSection\PartialViewSection\Views\_ViewImports.cshtml"
using PartialViewSection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code Academy\Teaching\Groupes\P222\Lessons\68.09.12.2021\Codes\PartialViewSection\PartialViewSection\Views\_ViewImports.cshtml"
using PartialViewSection.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Code Academy\Teaching\Groupes\P222\Lessons\68.09.12.2021\Codes\PartialViewSection\PartialViewSection\Views\_ViewImports.cshtml"
using PartialViewSection.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Code Academy\Teaching\Groupes\P222\Lessons\68.09.12.2021\Codes\PartialViewSection\PartialViewSection\Views\_ViewImports.cshtml"
using PartialViewSection.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baa13ef8afc197c91f7c69625aaf257d4351393b", @"/Views/Shared/_BannerPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3367806709322771f0ed7b312494991c57be9e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BannerPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Banner>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""hero-wrap hero-bread"" style=""background-image:url(images/xbg_1.jpg.pagespeed.ic.-7ny5J_MsG.jpg)"">
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-center justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center"">
                <p class=""breadcrumbs"">");
#nullable restore
#line 7 "D:\Code Academy\Teaching\Groupes\P222\Lessons\68.09.12.2021\Codes\PartialViewSection\PartialViewSection\Views\Shared\_BannerPartial.cshtml"
                                  Write(Model.SupTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h1 class=\"mb-0 bread\">");
#nullable restore
#line 8 "D:\Code Academy\Teaching\Groupes\P222\Lessons\68.09.12.2021\Codes\PartialViewSection\PartialViewSection\Views\Shared\_BannerPartial.cshtml"
                                  Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Banner> Html { get; private set; }
    }
}
#pragma warning restore 1591