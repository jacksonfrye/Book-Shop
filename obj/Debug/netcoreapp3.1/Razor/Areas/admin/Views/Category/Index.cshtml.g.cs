#pragma checksum "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0be82542dbe95bef5a33e2fd377d55f55dc240bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/admin/Views/Category/Index.cshtml")]
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
#line 1 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\_ViewImports.cshtml"
using Team27_BookshopWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\_ViewImports.cshtml"
using Team27_BookshopWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0be82542dbe95bef5a33e2fd377d55f55dc240bf", @"/Areas/admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3667651d14e1d3aae00ea6109d47e6ac91f05b07", @"/Areas/admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Team27_BookshopWeb.Areas.admin.Models.CategoryViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("screen"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Team27StaticFiles/mycss/admin.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowTmp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("item xoa"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Restore", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Danh sách các loại sách";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("style", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0be82542dbe95bef5a33e2fd377d55f55dc240bf8352", async() => {
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
            WriteLiteral("\n<div class=\"card searchfield\">\n    <div class=\"card-header\">Tìm kiếm</div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0be82542dbe95bef5a33e2fd377d55f55dc240bf9843", async() => {
                WriteLiteral(@"
        <div class=""card-body searchbox"">
            <div class=""row"">
                <div class=""col-sm-4"">
                    <label for=""select"" class="" form-control-label"">Nhập tên loại sách: </label>
                </div>
                <span class=""col-sm-5"">
                    <input type=""text"" id=""text-input"" name=""name"" placeholder=""Nhập loại sách cần tìm"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 820, "\"", 842, 1);
#nullable restore
#line (21,133)-(21,147) 29 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 828, Model.timKiem, 828, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                </span>\n\n            </div>\n            <div>\n                <button type=\"submit\" id=\"btnSearchLoaiSach\" class=\"btn btn-lg btn-info\">TÌM</button>\n            </div>\n        </div>\n\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        <!-- DATA TABLE -->\n        <h3 class=\"title-5 m-b-35\">\n            ");
#nullable restore
#line (38,14)-(38,58) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\Category\Index.cshtml"
Write(Html.DisplayFor(modelItem => Model.thongBao));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n        </h3>\n        <!-- ALERT -->\n\n");
#nullable restore
#line 42 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\Category\Index.cshtml"
           Html.RenderPartial("_AdminAlert", Model.MessagesView); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"table-data__tool\">\n\n            <div class=\"table-data__tool-right\">\n                <button class=\"au-btn au-btn-icon au-btn--green au-btn--small\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0be82542dbe95bef5a33e2fd377d55f55dc240bf13299", async() => {
                WriteLiteral("\n                        <i class=\"zmdi zmdi-plus\"></i>Thêm loại sách\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </button>\n                <button class=\"au-btn au-btn-icon au-btn--green au-btn--small\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0be82542dbe95bef5a33e2fd377d55f55dc240bf14671", async() => {
                WriteLiteral("\n                        <i class=\"zmdi zmdi-plus\"></i>Loại sách đã tạm xóa\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </button>\n                <button class=\"au-btn au-btn-icon au-btn--green au-btn--small\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0be82542dbe95bef5a33e2fd377d55f55dc240bf16049", async() => {
                WriteLiteral("\n                        <i class=\"zmdi zmdi-plus\"></i>Loại sách\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </button>\n            </div>\n        </div>\n");
#nullable restore
#line 64 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\Category\Index.cshtml"
         if (Model.categories.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""table-responsive table-responsive-data3"">
                <table class=""table table-data3"">
                    <thead>
                        <tr>
                            <th>
                                Tên loại sách
                            </th>
                            <th>
                                Ngày tạo
                            </th>
                            <th>
                                Ngày sửa
                            </th>

                            <th>
                                Thao tác
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 86 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\Category\Index.cshtml"
                         foreach (var item in Model.categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>\n                                    ");
#nullable restore
#line (90,38)-(90,77) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\Category\Index.cshtml"
Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line (93,38)-(93,82) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\Category\Index.cshtml"
Write(Html.DisplayFor(modelItem => item.CreatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line (96,38)-(96,82) 6 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\Category\Index.cshtml"
Write(Html.DisplayFor(modelItem => item.UpdatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n\n                                <td>\n                                    <div class=\"table-data-feature\">\n\n\n");
#nullable restore
#line 103 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\Category\Index.cshtml"
                                         if (Model.thongBao != "Tìm kiếm trên danh sách loại sách đã bị tạm xóa" && Model.thongBao != "Danh sách loại sách đã tạm xóa")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0be82542dbe95bef5a33e2fd377d55f55dc240bf20311", async() => {
                WriteLiteral("\n                                                <i class=\"zmdi zmdi-edit\"></i>\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line (105,94)-(105,101) 13 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\Category\Index.cshtml"
WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                            <button class=\"item xoa \"");
            BeginWriteAttribute("onclick", " onclick=\"", 4156, "\"", 4243, 8);
            WriteAttributeValue("", 4166, "confirmDelete(\'/admin/Category/Delete?id=", 4166, 41, true);
#nullable restore
#line (108,121)-(108,129) 30 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 4207, item.Id, 4207, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4215, "\',", 4215, 2, true);
            WriteAttributeValue(" ", 4217, "\'Bạn", 4218, 5, true);
            WriteAttributeValue(" ", 4222, "có", 4223, 3, true);
            WriteAttributeValue(" ", 4225, "muốn", 4226, 5, true);
            WriteAttributeValue(" ", 4230, "xóa", 4231, 4, true);
            WriteAttributeValue(" ", 4234, "không?\')", 4235, 9, true);
            EndWriteAttribute();
            WriteLiteral(">\n                                                <i class=\"zmdi zmdi-delete\"></i>\n                                            </button>\n");
#nullable restore
#line 111 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\Category\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 113 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\Category\Index.cshtml"
                                         if (Model.thongBao == "Tìm kiếm trên danh sách loại sách đã bị tạm xóa" || Model.thongBao == "Danh sách loại sách đã tạm xóa")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0be82542dbe95bef5a33e2fd377d55f55dc240bf24450", async() => {
                WriteLiteral("\n                                                <i class=\"fa fa-undo\"></i>\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line (115,101)-(115,108) 13 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\Category\Index.cshtml"
WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                            <button class=\"item xoa\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4936, "\"", 5030, 8);
            WriteAttributeValue("", 4946, "confirmDelete(\'/admin/Category/DeleteForever?id=", 4946, 48, true);
#nullable restore
#line (118,127)-(118,135) 30 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 4994, item.Id, 4994, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5002, "\',", 5002, 2, true);
            WriteAttributeValue(" ", 5004, "\'Bạn", 5005, 5, true);
            WriteAttributeValue(" ", 5009, "có", 5010, 3, true);
            WriteAttributeValue(" ", 5012, "muốn", 5013, 5, true);
            WriteAttributeValue(" ", 5017, "xóa", 5018, 4, true);
            WriteAttributeValue(" ", 5021, "không?\')", 5022, 9, true);
            EndWriteAttribute();
            WriteLiteral(">\n                                                <i class=\"zmdi zmdi-delete\"></i>\n                                            </button>\n");
#nullable restore
#line 121 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\Category\Index.cshtml"

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </div>\n                                </td>\n                            </tr>\n");
#nullable restore
#line 127 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\Category\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n");
#nullable restore
#line 131 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\Category\Index.cshtml"

        }
        else
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\n                Không có loại sách để hiển thị\n            </div>\n");
#nullable restore
#line 139 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\Category\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row pt--30\">\n            <div class=\"col-md-12\">\n                <div class=\"pagination-block\">\n                    <!--PHÂN TRANG-->\n                    <!--Gọi partial view hiển thị phân trang-->\n");
#nullable restore
#line 146 "D:\SP_Ecommerce-master\Team27_BookshopWeb\Areas\admin\Views\Category\Index.cshtml"
                       Html.RenderPartial("_Pagination", new PaginationViewModel(Model.AllPages, Model.CurrentPage));

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Team27_BookshopWeb.Areas.admin.Models.CategoryViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591