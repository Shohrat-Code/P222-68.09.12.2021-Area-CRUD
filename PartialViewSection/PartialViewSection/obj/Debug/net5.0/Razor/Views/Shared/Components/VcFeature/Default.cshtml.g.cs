#pragma checksum "D:\Code Academy\Teaching\Groupes\P222\Lessons\68.09.12.2021\Codes\PartialViewSection\PartialViewSection\Views\Shared\Components\VcFeature\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dd5bbb89e22a0815494d63b36e6723c9fdd13ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_VcFeature_Default), @"mvc.1.0.view", @"/Views/Shared/Components/VcFeature/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dd5bbb89e22a0815494d63b36e6723c9fdd13ce", @"/Views/Shared/Components/VcFeature/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3367806709322771f0ed7b312494991c57be9e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_VcFeature_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Feature>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Code Academy\Teaching\Groupes\P222\Lessons\68.09.12.2021\Codes\PartialViewSection\PartialViewSection\Views\Shared\Components\VcFeature\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"ftco-section\">\r\n    <div class=\"container\">\r\n        <div class=\"row no-gutters ftco-services\">\r\n");
#nullable restore
#line 9 "D:\Code Academy\Teaching\Groupes\P222\Lessons\68.09.12.2021\Codes\PartialViewSection\PartialViewSection\Views\Shared\Components\VcFeature\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-3 text-center d-flex align-self-stretch ftco-animate"">
                    <div class=""media block-6 services mb-md-0 mb-4"">
                        <div class=""icon bg-color-1 active d-flex justify-content-center align-items-center mb-2"">
                            <span");
            BeginWriteAttribute("class", " class=\"", 532, "\"", 550, 1);
#nullable restore
#line 14 "D:\Code Academy\Teaching\Groupes\P222\Lessons\68.09.12.2021\Codes\PartialViewSection\PartialViewSection\Views\Shared\Components\VcFeature\Default.cshtml"
WriteAttributeValue("", 540, item.Icon, 540, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                        </div>\r\n                        <div class=\"media-body\">\r\n                            <h3 class=\"heading\">");
#nullable restore
#line 17 "D:\Code Academy\Teaching\Groupes\P222\Lessons\68.09.12.2021\Codes\PartialViewSection\PartialViewSection\Views\Shared\Components\VcFeature\Default.cshtml"
                                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <span>");
#nullable restore
#line 18 "D:\Code Academy\Teaching\Groupes\P222\Lessons\68.09.12.2021\Codes\PartialViewSection\PartialViewSection\Views\Shared\Components\VcFeature\Default.cshtml"
                             Write(item.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 22 "D:\Code Academy\Teaching\Groupes\P222\Lessons\68.09.12.2021\Codes\PartialViewSection\PartialViewSection\Views\Shared\Components\VcFeature\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Feature>> Html { get; private set; }
    }
}
#pragma warning restore 1591