#pragma checksum "C:\Users\gcltr\source\repos\ReservationOfTravel\ReservationOfTravel\Views\Shared\Components\_FeatureHeaders\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cf18b253fe05e04770697f3c9a67f1099886908"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__FeatureHeaders_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_FeatureHeaders/Default.cshtml")]
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
#line 1 "C:\Users\gcltr\source\repos\ReservationOfTravel\ReservationOfTravel\Views\_ViewImports.cshtml"
using ReservationOfTravel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gcltr\source\repos\ReservationOfTravel\ReservationOfTravel\Views\_ViewImports.cshtml"
using ReservationOfTravel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\gcltr\source\repos\ReservationOfTravel\ReservationOfTravel\Views\Shared\Components\_FeatureHeaders\Default.cshtml"
using EntityLayer.Concretes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cf18b253fe05e04770697f3c9a67f1099886908", @"/Views/Shared/Components/_FeatureHeaders/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca8edbbd4e5ecb080a03bf82b72a10aa0354492a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__FeatureHeaders_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FeatureHeader>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"maghny-gd-1 col-lg-6\">//\r\n              <div class=\"maghny-grid\">\r\n                <figure class=\"effect-lily border-radius  m-0\">\r\n");
#nullable restore
#line 7 "C:\Users\gcltr\source\repos\ReservationOfTravel\ReservationOfTravel\Views\Shared\Components\_FeatureHeaders\Default.cshtml"
                     foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 296, "\"", 323, 1);
#nullable restore
#line 8 "C:\Users\gcltr\source\repos\ReservationOfTravel\ReservationOfTravel\Views\Shared\Components\_FeatureHeaders\Default.cshtml"
WriteAttributeValue("", 302, item.HeaderPostImage, 302, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 324, "\"", 330, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <figcaption>\r\n                        <div>\r\n                            <h4>");
#nullable restore
#line 11 "C:\Users\gcltr\source\repos\ReservationOfTravel\ReservationOfTravel\Views\Shared\Components\_FeatureHeaders\Default.cshtml"
                           Write(item.HeaderTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <p>Sadece ");
#nullable restore
#line 12 "C:\Users\gcltr\source\repos\ReservationOfTravel\ReservationOfTravel\Views\Shared\Components\_FeatureHeaders\Default.cshtml"
                                 Write(item.HeaderPostDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</p>\r\n                        </div>\r\n\r\n                    </figcaption>\r\n");
#nullable restore
#line 16 "C:\Users\gcltr\source\repos\ReservationOfTravel\ReservationOfTravel\Views\Shared\Components\_FeatureHeaders\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </figure>\r\n            </div>\r\n            </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FeatureHeader>> Html { get; private set; }
    }
}
#pragma warning restore 1591
