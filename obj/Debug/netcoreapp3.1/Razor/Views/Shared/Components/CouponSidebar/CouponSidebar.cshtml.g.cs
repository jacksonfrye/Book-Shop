#pragma checksum "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\Components\CouponSidebar\CouponSidebar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4414391226f61e4dec8b488131dda0e7ead9d825"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CouponSidebar_CouponSidebar), @"mvc.1.0.view", @"/Views/Shared/Components/CouponSidebar/CouponSidebar.cshtml")]
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
#line 1 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\_ViewImports.cshtml"
using Team27_BookshopWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\_ViewImports.cshtml"
using Team27_BookshopWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4414391226f61e4dec8b488131dda0e7ead9d825", @"/Views/Shared/Components/CouponSidebar/CouponSidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3667651d14e1d3aae00ea6109d47e6ac91f05b07", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CouponSidebar_CouponSidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Team27_BookshopWeb.Models.CouponSidebarViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\Components\CouponSidebar\CouponSidebar.cshtml"
  
    var url = Context.Request.Path.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"single-block \">\n    <h2 class=\"sidebar-title mb--30\">Tags</h2>\n    <ul class=\"sidebar-tag-list\">\n");
#nullable restore
#line 12 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\Components\CouponSidebar\CouponSidebar.cshtml"
         if (Model.CouponTypes.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\Components\CouponSidebar\CouponSidebar.cshtml"
             foreach (var type in Model.CouponTypes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 481, "\"", 523, 2);
            WriteAttributeValue("", 488, "/ma-khuyen-mai/tags/", 488, 20, true);
#nullable restore
#line (16,50)-(16,65) 29 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\Components\CouponSidebar\CouponSidebar.cshtml"
WriteAttributeValue("", 508, type.ToLower(), 508, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 524, "\"", 589, 1);
#nullable restore
#line (16,74)-(16,131) 29 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\Components\CouponSidebar\CouponSidebar.cshtml"
WriteAttributeValue("", 532, url.Contains(type.ToLower()) ? "active" : string.Empty, 532, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line (16,135)-(16,139) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\Components\CouponSidebar\CouponSidebar.cshtml"
Write(type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 17 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\Components\CouponSidebar\CouponSidebar.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\Components\CouponSidebar\CouponSidebar.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><a href=\"/ma-khuyen-mai\"");
            BeginWriteAttribute("class", " class=\"", 667, "\"", 725, 1);
#nullable restore
#line (19,45)-(19,95) 29 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\Components\CouponSidebar\CouponSidebar.cshtml"
WriteAttributeValue("", 675, url=="/ma-khuyen-mai" ? "active" : string.Empty, 675, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Khuyến mãi</a></li>\n    </ul>\n</div>\n<div class=\"single-block \">\n    <h2 class=\"sidebar-title mb--30\">KHUYỄN MÃI GẦN ĐÂY</h2>\n    <ul class=\"sidebar-list\">\n");
#nullable restore
#line 25 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\Components\CouponSidebar\CouponSidebar.cshtml"
         if (Model.NewCoupons.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\Components\CouponSidebar\CouponSidebar.cshtml"
             foreach (var coupon in Model.NewCoupons)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 1027, "\"", 1061, 2);
            WriteAttributeValue("", 1034, "/ma-khuyen-mai/", 1034, 15, true);
#nullable restore
#line (29,45)-(29,57) 30 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\Components\CouponSidebar\CouponSidebar.cshtml"
WriteAttributeValue("", 1049, coupon.Slug, 1049, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line (29,61)-(29,72) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\Components\CouponSidebar\CouponSidebar.cshtml"
Write(coupon.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 30 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\Components\CouponSidebar\CouponSidebar.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\Components\CouponSidebar\CouponSidebar.cshtml"
             

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n</div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Team27_BookshopWeb.Models.CouponSidebarViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591