#pragma checksum "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a1f3296c4da520cc2a803ba8a1bd0f43cd8059e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a1f3296c4da520cc2a803ba8a1bd0f43cd8059e", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3667651d14e1d3aae00ea6109d47e6ac91f05b07", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Team27_BookshopWeb.Models.ShopViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("screen"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Team27StaticFiles/mycss/shop.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "default", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "nameasc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "namedesc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "priceasc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "pricedesc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "viewdesc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "viewasc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control nice-select sort-select mr-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "sort", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("this.form.submit();"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shop\Index.cshtml"
  
    ViewData["Title"] = "Cửa hàng";
    Layout = "~/Views/Shared/_Master.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("style", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9a1f3296c4da520cc2a803ba8a1bd0f43cd8059e9232", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            WriteLiteral("\n");
            WriteLiteral(@"
<section class=""breadcrumb-section"">
    <h2 class=""sr-only"">Site Breadcrumb</h2>
    <div class=""container"">
        <div class=""breadcrumb-contents"">
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item""><a href=""/"">Trang chủ</a></li>
                    <li class=""breadcrumb-item""><a");
            BeginWriteAttribute("href", " href=\"", 623, "\"", 662, 5);
            WriteAttributeValue("", 630, "/", 630, 1, true);
#nullable restore
#line (20,59)-(20,70) 29 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shop\Index.cshtml"
WriteAttributeValue("", 631, Model.Type, 631, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 642, "/", 642, 1, true);
#nullable restore
#line (20,71)-(20,89) 29 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shop\Index.cshtml"
WriteAttributeValue("", 643, Model.DisplayPath, 643, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 661, "/", 661, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n                    ");
#nullable restore
#line (21,22)-(21,45) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shop\Index.cshtml"
Write(Model.DisplayBreadcrumb);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </a></li>
                    <!-- breadcrumb -->
                </ol>
            </nav>
        </div>
    </div>
</section>
<main class=""inner-page-sec-padding-bottom"">
    <div class=""container"">
        <div class=""row"">

            <div class=""col-lg-9 order-lg-2"">
                <!-- Hiển thị kết quả tìm kiếm cho -->
                <h3 id=""shop-page-description"">");
#nullable restore
#line (35,49)-(35,66) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shop\Index.cshtml"
Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(": <span id=\"book-count\">");
#nullable restore
#line (35,91)-(35,110) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shop\Index.cshtml"
Write(Model.Books.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line (35,114)-(35,125) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shop\Index.cshtml"
Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" kết quả</span></h3>
                <div class=""shop-toolbar with-sidebar mb--30"">

                    <div class=""row align-items-center"">

                        <div class=""col-lg-2 col-md-2 col-sm-6"">
                            <!-- Product View Mode -->
                            <div class=""product-view-mode"">
                                <a href=""#"" class=""sorting-btn active"" data-target=""grid"">
                                    <i class=""fas fa-th""></i>
                                </a>
                                <a href=""#"" class=""sorting-btn"" data-target=""grid-four"">
                                    <span class=""grid-four-icon"">
                                        <i class=""fas fa-grip-vertical""></i><i class=""fas fa-grip-vertical""></i>
                                    </span>
                                </a>
                            </div>
                        </div>
                        <div class=""col-lg-4 col-md-4 col-sm-6 mt--10 mt-md--0 "">
              ");
            WriteLiteral("              <div class=\"sorting-selection\">\n                                <span>Sắp xếp:</span>\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a1f3296c4da520cc2a803ba8a1bd0f43cd8059e14394", async() => {
                WriteLiteral("\n");
#nullable restore
#line 57 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                                     if (Model.search != null)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input type=\"hidden\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 2532, "\"", 2553, 1);
#nullable restore
#line (59,81)-(59,94) 30 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shop\Index.cshtml"
WriteAttributeValue("", 2540, Model.search, 2540, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n");
#nullable restore
#line 60 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input type=\"hidden\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 2747, "\"", 2768, 1);
#nullable restore
#line (63,81)-(63,94) 30 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shop\Index.cshtml"
WriteAttributeValue("", 2755, Model.search, 2755, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled/>\n");
#nullable restore
#line 64 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a1f3296c4da520cc2a803ba8a1bd0f43cd8059e16421", async() => {
                    WriteLiteral("\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a1f3296c4da520cc2a803ba8a1bd0f43cd8059e16728", async() => {
                        WriteLiteral("Mặc định");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a1f3296c4da520cc2a803ba8a1bd0f43cd8059e18147", async() => {
                        WriteLiteral("\n                                            Tên: (A - Z)\n                                        ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a1f3296c4da520cc2a803ba8a1bd0f43cd8059e19567", async() => {
                        WriteLiteral("\n                                            Tên: (Z - A)\n                                        ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a1f3296c4da520cc2a803ba8a1bd0f43cd8059e20987", async() => {
                        WriteLiteral("\n                                            Giá: (Thấp &gt; cao)\n                                        ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a1f3296c4da520cc2a803ba8a1bd0f43cd8059e22415", async() => {
                        WriteLiteral("\n                                            Giá: (Cao &gt; Thấp)\n                                        ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_9.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a1f3296c4da520cc2a803ba8a1bd0f43cd8059e23843", async() => {
                        WriteLiteral("\n                                            Lượt xem: (Cao nhất)\n                                        ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_10.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a1f3296c4da520cc2a803ba8a1bd0f43cd8059e25273", async() => {
                        WriteLiteral("\n                                            Lượt xem: (Thấp nhất)\n                                        ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_11.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 66 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shop\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.sort);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_15.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                            </div>
                        </div>
                    </div>
                </div>
                <div class=""shop-toolbar d-none"">
                    <div class=""row align-items-center"">
                        <div class=""col-lg-2 col-md-2 col-sm-6"">
                            <!-- Product View Mode -->
                            <div class=""product-view-mode"">
                                <a href=""#"" class=""sorting-btn active"" data-target=""grid"">
                                    <i class=""fas fa-th""></i>
                                </a>
                                <a href=""#"" class=""sorting-btn"" data-target=""grid-four"">
                                    <span class=""grid-four-icon"">
                                        <i class=""fas fa-grip-vertical""></i><i class=""fas fa-grip-vertical""></i>
                                    </span>
                                </a>
                                <a href=""#"" class=""sorting-btn"" data-target=""lis");
            WriteLiteral(@"t "">
                                    <i class=""fas fa-list""></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""shop-product-wrap grid with-pagination row space-db--30 shop-border"">
                    <!-- Hiển thị sách -->
");
#nullable restore
#line 115 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                     foreach (var book in Model.Books)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 col-sm-6\">\n                            <!--Gọi partial view hiển thị thông tin sách-->\n");
#nullable restore
#line 119 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                               Html.RenderPartial("_ProductCard", book);

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\n");
#nullable restore
#line 121 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <!-- Pagination Block -->
                <div class=""row pt--30"">
                    <div class=""col-md-12"">
                        <div class=""pagination-block"">
                            <!-- Phân trang link -->
                            <!--Gọi partial view hiển thị phân trang-->
");
#nullable restore
#line 129 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                               Html.RenderPartial("_Pagination", new PaginationViewModel(Model.AllPages, Model.CurrentPage));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3  mt--40 mt-lg--0"">
                <div class=""inner-page-sidebar"">
                    <!-- Accordion -->
                    <div class=""single-block"">
                        <h3 class=""sidebar-title"">Loại sách</h3>
                        <ul class=""sidebar-menu--shop"">
                            <!-- Danh sách loại sách -->
                            ");
#nullable restore
#line (141,30)-(141,97) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shop\Index.cshtml"
Write(await Component.InvokeAsync("CategoriesPublisherList", "loai-sach"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </ul>
                    </div>

                    <div class=""single-block"">
                        <h3 class=""sidebar-title"">Nhà xuất bản</h3>
                        <ul class=""sidebar-menu--shop menu-type-2"">
                            <!-- Danh sách nhà xuất bản -->
                            ");
#nullable restore
#line (149,30)-(149,100) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shop\Index.cshtml"
Write(await Component.InvokeAsync("CategoriesPublisherList", "nha-xuat-ban"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </ul>
                    </div>

                    <!-- Box Facebook page like -->
                    <div class=""single-block"">
                        <div class=""fb-page"" 
                             data-href=""https://www.facebook.com/Linhttk27"" 
                             data-tabs=""timeline"" 
                             data-width="""" 
                             data-height="""" 
                             data-small-header=""true"" 
                             data-adapt-container-width=""true"" 
                             data-hide-cover=""false"" 
                             data-show-facepile=""true"">
                        <blockquote cite=""https://www.facebook.com/Linhttk27"" class=""fb-xfbml-parse-ignore"">
                            <a href=""https://www.facebook.com/Linhttk27"">TwentySven - Ở đây có bán Sách</a>
                            </blockquote>
                        </div>
                    </div>

                    <!-- RSS Feeds Area -->
");
#nullable restore
#line 171 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                     try
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line (173,26)-(173,64) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shop\Index.cshtml"
Write(await Component.InvokeAsync("RssFeed"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 173 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shop\Index.cshtml"
                                                               
                    }
                    catch (Exception)
                    {
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n</main>\n\t</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Team27_BookshopWeb.Models.ShopViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
