#pragma checksum "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\Components\FavoriteBook\FavoriteBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd83a4b0457b3461863f98aa301822498e72ec33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FavoriteBook_FavoriteBook), @"mvc.1.0.view", @"/Views/Shared/Components/FavoriteBook/FavoriteBook.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd83a4b0457b3461863f98aa301822498e72ec33", @"/Views/Shared/Components/FavoriteBook/FavoriteBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3667651d14e1d3aae00ea6109d47e6ac91f05b07", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_FavoriteBook_FavoriteBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<button class=\"single-btn addToWishList\" data-proid=\'");
#nullable restore
#line (5,55)-(5,69) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\Components\FavoriteBook\FavoriteBook.cshtml"
Write(ViewBag.BookId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'>\n");
#nullable restore
#line 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\Components\FavoriteBook\FavoriteBook.cshtml"
     if (Model == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <i class=\"fas fa-heart loved\"></i>\n");
#nullable restore
#line 9 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\Components\FavoriteBook\FavoriteBook.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <i class=\"fas fa-heart\"></i>\n");
#nullable restore
#line 13 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Views\Shared\Components\FavoriteBook\FavoriteBook.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</button>");
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
