#pragma checksum "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afeb1b00fde845d6517bc0df30631fdcfcae8096"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CouponGallery_Index), @"mvc.1.0.view", @"/Views/CouponGallery/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afeb1b00fde845d6517bc0df30631fdcfcae8096", @"/Views/CouponGallery/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3667651d14e1d3aae00ea6109d47e6ac91f05b07", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CouponGallery_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Team27_BookshopWeb.Models.CouponGalleryViewModel>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
  
    ViewData["Title"] = "Mã khuyến mãi";
    Layout = "~/Views/Shared/_CouponLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"blog-list-cards\">\n");
#nullable restore
#line 9 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
         if (Model.Coupons.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
             foreach (var coupon in Model.Coupons)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"blog-card card-style-list\">\n                    <div class=\"row\">\n                        <div class=\"col-md-5\">\n                            <a");
            BeginWriteAttribute("href", " href=\"", 476, "\"", 510, 2);
            WriteAttributeValue("", 483, "/ma-khuyen-mai/", 483, 15, true);
#nullable restore
#line (16,53)-(16,65) 29 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
WriteAttributeValue("", 498, coupon.Slug, 498, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image d-block\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "afeb1b00fde845d6517bc0df30631fdcfcae80964675", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 577, "~/Team27StaticFiles/images/coupon/", 577, 34, true);
#nullable restore
#line (17,77)-(17,90) 31 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
AddHtmlAttributeValue("", 611, coupon.Image, 611, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line (17,97)-(17,109) 31 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
AddHtmlAttributeValue("", 631, coupon.Name, 631, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </a>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""card-content"">
                                <h3 class=""title"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 901, "\"", 935, 2);
            WriteAttributeValue("", 908, "/ma-khuyen-mai/", 908, 15, true);
#nullable restore
#line (23,61)-(23,73) 29 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
WriteAttributeValue("", 923, coupon.Slug, 923, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                        ");
#nullable restore
#line (24,42)-(24,53) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
Write(coupon.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </a>\n                                </h3>\n                                <p class=\"post-meta\"><span>");
#nullable restore
#line (27,61)-(27,111) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
Write(coupon.CreatedAt.ToString("dd/MM/yyyy - HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></p>\n                                <article>\n                                    <h2 class=\"sr-only\">\n                                        Coupon description\n                                    </h2>\n                                    <p>\n");
#nullable restore
#line 33 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
                                         if (coupon.Description.Length >= 200)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line (35,46)-(35,119) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
Write(coupon.Description.Replace("<br>", Environment.NewLine).Substring(0, 200));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
                                                                                                                      ;
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line (39,46)-(39,101) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
Write(coupon.Description.Replace("<br>", Environment.NewLine));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
                                                                                                    
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...\n                                    </p>\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2029, "\"", 2063, 2);
            WriteAttributeValue("", 2036, "/ma-khuyen-mai/", 2036, 15, true);
#nullable restore
#line (42,61)-(42,73) 30 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
WriteAttributeValue("", 2051, coupon.Slug, 2051, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"blog-link\"> Xem thêm</a>\n                                </article>\n                            </div>\n                        </div>\n\n                    </div>\n                </div>\n");
#nullable restore
#line 49 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-12\">\n                <div class=\"pagination-block\">\n                    <!-- Phân trang link -->\n                    <!--Gọi partial view hiển thị phân trang-->\n");
#nullable restore
#line 54 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
                       Html.RenderPartial("_Pagination", new PaginationViewModel(Model.AllPages, Model.CurrentPage));

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n");
#nullable restore
#line 57 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>Không có mã khuyến mãi nào</div>\n");
#nullable restore
#line 61 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\CouponGallery\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Team27_BookshopWeb.Models.CouponGalleryViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591