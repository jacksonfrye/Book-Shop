#pragma checksum "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87113357e5a0522f01de93c9d5d31e344f9934fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BookQuickView), @"mvc.1.0.view", @"/Views/Shared/_BookQuickView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87113357e5a0522f01de93c9d5d31e344f9934fa", @"/Views/Shared/_BookQuickView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3667651d14e1d3aae00ea6109d47e6ac91f05b07", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__BookQuickView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Team27_BookshopWeb.Models.ProductDetailsViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("u-photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("qv-book-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
  
    var book = Model.book;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""modal fade modal-quick-view"" id=""quickModal"" tabindex=""-1"" role=""dialog""
     aria-labelledby=""quickModal"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <button type=""button"" class=""close modal-close-btn ml-auto"" data-dismiss=""modal"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
            </button>
            <div class=""product-details-modal"">
                <div class=""row h-product"">
                    <div class=""col-lg-5"">
                        <!-- Product Details Slider Big Image-->
                        <div class=""product-details-slider sb-slick-slider arrow-type-two"">
                            <div class=""single-slide"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "87113357e5a0522f01de93c9d5d31e344f9934fa4955", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1048, "~/Team27StaticFiles/images/books/", 1048, 33, true);
#nullable restore
#line (23,111)-(23,129) 32 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
AddHtmlAttributeValue("", 1081, book.PrimaryImage, 1081, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line (23,136)-(23,153) 32 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
AddHtmlAttributeValue("", 1106, book.DisplayName, 1106, 17, false);

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
            WriteLiteral("\n                            </div>\n                        </div>\n                        <!-- Product Details Slider Nav -->\n");
            WriteLiteral("                    </div>\n                    <div class=\"col-lg-7 mt--30 mt-lg--30\">\n                        <div class=\"product-details-info pl-lg--30 \">\n                            <h3 class=\"product-title p-name\">\n                                <a");
            BeginWriteAttribute("href", " href=\"", 4120, "\"", 4143, 2);
            WriteAttributeValue("", 4127, "/sach/", 4127, 6, true);
#nullable restore
#line (61,48)-(61,58) 30 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
WriteAttributeValue("", 4133, book.Slug, 4133, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"qv-book-name\">\n                                    ");
#nullable restore
#line (62,38)-(62,54) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
Write(book.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </a>\n                            </h3>\n                            <ul class=\"list-unstyled\">\n                                <li>\n                                    Tác giả:\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 4464, "\"", 4497, 2);
            WriteAttributeValue("", 4471, "/tac-gia/", 4471, 9, true);
#nullable restore
#line (68,55)-(68,72) 30 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
WriteAttributeValue("", 4480, book.Author.Slug, 4480, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-value font-weight-bold\" id=\"qv-author-name\">\n                                        ");
#nullable restore
#line (69,42)-(69,65) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
Write(book.Author.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </a>\n                                </li>\n\n");
#nullable restore
#line 73 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
                                 if (book.Translator != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>\n                                        Dịch giả: <a");
            BeginWriteAttribute("href", " href=\"", 4890, "\"", 4928, 2);
            WriteAttributeValue("", 4897, "/dich-gia/", 4897, 10, true);
#nullable restore
#line (76,70)-(76,91) 30 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
WriteAttributeValue("", 4907, book.Translator.Slug, 4907, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-value font-weight-bold\" id=\"qv-translator-name\">\n                                            ");
#nullable restore
#line (77,46)-(77,73) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
Write(book.Translator.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </a>\n                                    </li>\n");
#nullable restore
#line 80 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                <li>\n                                    Nhà xuất bản:\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 5311, "\"", 5352, 2);
            WriteAttributeValue("", 5318, "/nha-xuat-ban/", 5318, 14, true);
#nullable restore
#line (84,60)-(84,80) 30 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
WriteAttributeValue("", 5332, book.Publisher.Slug, 5332, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-value font-weight-bold\" id=\"qv-publisher-name\">\n                                        ");
#nullable restore
#line (85,42)-(85,68) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
Write(book.Publisher.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </a>
                                </li>

                                <li>
                                    Ngày xuất bản:
                                    <span class=""list-value"" id=""qv-publication-date"">
                                        ");
#nullable restore
#line (92,42)-(92,62) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
Write(book.PublicationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </span>\n                                </li>\n\n");
#nullable restore
#line 96 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
                                 if (book.Pages > 0 && book.Pages != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>\n                                        Số trang:\n                                        <span id=\"qv-book-pages\">\n                                            ");
#nullable restore
#line (101,46)-(101,56) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
Write(book.Pages);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </span> trang\n                                    </li>\n");
#nullable restore
#line 104 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </ul>\n                            <div class=\"price-block\">\n                                <span class=\"price-new p-price\" id=\"qv-book-price\" data-proprice=\"");
#nullable restore
#line (108,100)-(108,110) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
Write(book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                                    ");
#nullable restore
#line (109,38)-(109,55) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
Write(book.DisplayPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </span>
                            </div>
                            <div class=""rating-widget"">
                                <div class=""rating-block"">
                                    <span>
                                        <span itemprop=""ratingValue"" id=""qv-rating-value"">");
#nullable restore
#line (115,92)-(115,111) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
Write(Model.averageRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>/5\n                                    </span>\n                                    <!-- Rating stars -->\n");
#nullable restore
#line 118 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
                                     for (int i = 1; i <= 5; i++)
                                    {
                                        if (i <= Math.Floor(Model.averageRating))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"fas fa-star star_on\"></span>\n");
#nullable restore
#line 123 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"fas fa-star\"></span>\n");
#nullable restore
#line 127 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\n                                <div class=\"review-widget\">\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 7783, "\"", 7806, 2);
            WriteAttributeValue("", 7790, "/sach/", 7790, 6, true);
#nullable restore
#line (131,52)-(131,62) 30 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
WriteAttributeValue("", 7796, book.Slug, 7796, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration: underline; color: blue \">Nhận xét (<span class=\"count\">");
#nullable restore
#line (131,144)-(131,166) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
Write(Model.numberOfComments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>)</a> <span>|</span>\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 7976, "\"", 7999, 2);
            WriteAttributeValue("", 7983, "/sach/", 7983, 6, true);
#nullable restore
#line (132,52)-(132,62) 30 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
WriteAttributeValue("", 7989, book.Slug, 7989, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""text-decoration: underline; color: blue "">Viết nhận xét</a>
                                </div>
                            </div>
                            <article class=""product-details-article"">
                                <h4 class=""sr-only"">Tóm tắt</h4>
                                <p id=""qv-short-description"">
");
#nullable restore
#line 138 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
                                     if (book.Description.Length >= 200)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line (140,42)-(140,113) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
Write(book.Description.Replace("<br>", Environment.NewLine).Substring(0, 200));

#line default
#line hidden
#nullable disable
#nullable restore
#line 140 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
                                                                                                                ;
                                    }
                                    else
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line (144,42)-(144,58) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
Write(book.Description);

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
                                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...<a");
            BeginWriteAttribute("href", " href=\"", 8782, "\"", 8805, 2);
            WriteAttributeValue("", 8789, "/sach/", 8789, 6, true);
#nullable restore
#line (145,57)-(145,67) 30 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
WriteAttributeValue("", 8795, book.Slug, 8795, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""text-decoration: underline; color: blue ""> xem thêm</a>
                                </p>
                            </article>
                            <div class=""add-to-cart-row"">
                                <div class=""count-input-block"">
                                    <span class=""widget-label"">Số lượng</span>
                                    <!--pattern: Chỉ được nhập số, không được bắt đầu bởi 0-->
                                    <input type=""number"" id=""quantity"" min=""1"" name=""quantity"" class=""form-control text-center"" value=""1"" pattern=""[^0|\D]\d{0,}$"" required>
                                </div>
                                <div class=""add-cart-btn"">
                                    <button id=""pro-detail-atc"" class=""btn btn-outlined--primary addToCart"" data-proid='");
#nullable restore
#line (155,122)-(155,129) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
Write(book.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'>
                                        <span class=""plus-icon"">+</span>Thêm vào giỏ hàng
                                    </button>
                                </div>
                            </div>
                            <div class=""compare-wishlist-row"">
                                <span>");
#nullable restore
#line (161,40)-(161,92) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BookQuickView.cshtml"
Write(await Component.InvokeAsync("FavoriteBook", book.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"   Thêm vào danh sách yêu thích</span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Team27_BookshopWeb.Models.ProductDetailsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591