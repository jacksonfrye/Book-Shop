#pragma checksum "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BooksSliderMulti.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4083c4e1a8ae3e77280ec059d757f7c7efb90c71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BooksSliderMulti), @"mvc.1.0.view", @"/Views/Shared/_BooksSliderMulti.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4083c4e1a8ae3e77280ec059d757f7c7efb90c71", @"/Views/Shared/_BooksSliderMulti.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3667651d14e1d3aae00ea6109d47e6ac91f05b07", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__BooksSliderMulti : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px; height:120px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BooksSliderMulti.cshtml"
   var books = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""product-slider product-list-slider multiple-row slider-border-multiple-row  sb-slick-slider""
         data-slick-setting='{
                           	""autoplay"": true,
                            ""autoplaySpeed"": 8000,
                            ""slidesToShow"": 3,
                            ""rows"":3,
                            ""dots"":true
                        }' data-slick-responsive='[
                            {""breakpoint"":992, ""settings"": {""slidesToShow"": 2,""rows"": 3} },

                            {""breakpoint"":768, ""settings"": {""slidesToShow"": 1} }
                        ]'>


");
#nullable restore
#line 20 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BooksSliderMulti.cshtml"
         foreach (var book in books)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"single-slide\">\n                <div class=\"product-card card-style-list\">\n                    <div class=\"card-image\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4083c4e1a8ae3e77280ec059d757f7c7efb90c714820", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 985, "~/Team27StaticFiles/images/books/", 985, 33, true);
#nullable restore
#line (25,68)-(25,86) 32 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BooksSliderMulti.cshtml"
AddHtmlAttributeValue("", 1018, book.PrimaryImage, 1018, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line (25,127)-(25,144) 32 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BooksSliderMulti.cshtml"
AddHtmlAttributeValue("", 1077, book.DisplayName, 1077, 17, false);

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
            WriteLiteral("\n                    </div>\n                    <div class=\"product-card--body\">\n                        <div class=\"product-header\">\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1260, "\"", 1293, 2);
            WriteAttributeValue("", 1267, "/tac-gia/", 1267, 9, true);
#nullable restore
#line (29,47)-(29,64) 30 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BooksSliderMulti.cshtml"
WriteAttributeValue("", 1276, book.Author.Slug, 1276, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"author\">\n                                ");
#nullable restore
#line (30,34)-(30,57) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BooksSliderMulti.cshtml"
Write(book.Author.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </a>\n                            <h3><a");
            BeginWriteAttribute("href", " href=\"", 1435, "\"", 1458, 2);
            WriteAttributeValue("", 1442, "/sach/", 1442, 6, true);
#nullable restore
#line (32,48)-(32,58) 30 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BooksSliderMulti.cshtml"
WriteAttributeValue("", 1448, book.Slug, 1448, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line (32,61)-(32,77) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BooksSliderMulti.cshtml"
Write(book.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\n                        </div>\n                        <div class=\"price-block\">\n                            <span class=\"price\">");
#nullable restore
#line (35,50)-(35,67) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BooksSliderMulti.cshtml"
Write(book.DisplayPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                        </div>\n                    </div>\n                </div>\n            </div>\n");
#nullable restore
#line 40 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\_BooksSliderMulti.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
