#pragma checksum "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f0b2bc58576fc7cc7e244a94ab058dd220d25b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AlSat_StokSat), @"mvc.1.0.view", @"/Views/AlSat/StokSat.cshtml")]
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
#line 1 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\_ViewImports.cshtml"
using StokTakipProgramı;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\_ViewImports.cshtml"
using StokTakipProgramı.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\_ViewImports.cshtml"
using StokTakipProgramı.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f0b2bc58576fc7cc7e244a94ab058dd220d25b7", @"/Views/AlSat/StokSat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f9095be974e5153e800cb80f16895f4b50c15d2", @"/Views/_ViewImports.cshtml")]
    public class Views_AlSat_StokSat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Theme/plugins/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AlSat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SatisYap", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
  
    ViewData["Title"] = "StokSat";


#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
  
    var stokkart = ViewBag.StokKart;
    var depo = ViewBag.Depolar;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f0b2bc58576fc7cc7e244a94ab058dd220d25b75300", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<!-- Main content -->
<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">

                <div style=""margin-top:10px"" class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Satış Yapmak İstediğiniz Ürünü Seçin</h3>
                    </div>
                    <!-- /.card-header -->
");
#nullable restore
#line 25 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
                     if (Model.Count() > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""card-body"">
                            <table id=""example2"" class=""table table-bordered table-striped"">
                                <thead>
                                    <tr>
                                        <th>Ürün Kodu</th>
                                        <th>Ürün Adı</th>
                                        <th>Ürün Birimi</th>
                                        <th>Ürün Açıklama</th>
                                        <th>Alış Fiyatı</th>
                                        <th>Satış Fiyatı</th>
                                        <th>Ürün Adedi</th>
                                        <th>Depo Adı</th>
                                        <th></th>

                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 44 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n");
#nullable restore
#line 47 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
                                             foreach (var stok in stokkart)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
                                                 if (stok.StokKartId == item.StokKartId)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td>");
#nullable restore
#line 51 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
                                                   Write(stok.StokKodu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 52 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
                                                   Write(stok.StokAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 53 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
                                                   Write(stok.StokBirim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td style=\"max-width:300px\">");
#nullable restore
#line 54 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
                                                                           Write(stok.StokAciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 55 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
                                                   Write(stok.StokAlis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 56 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
                                                   Write(stok.StokSatis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 57 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
                                                 
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>");
#nullable restore
#line 59 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
                                           Write(item.ProductAdet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 61 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
                                             foreach (var dp in depo)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
                                                 if (dp.DepoId == item.DepoId)
                                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td>");
#nullable restore
#line 66 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
                                                   Write(dp.DepoAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 67 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
                                                 
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            <td>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f0b2bc58576fc7cc7e244a94ab058dd220d25b713599", async() => {
                WriteLiteral("\r\n                                                    Satış Yap\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
                                                                                                                                 WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
                                                                                                                                                                   WriteLiteral(item.ProductAdet);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["value"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-value", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["value"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("                                              \r\n                                            </td>\r\n\r\n                                        </tr>\r\n");
#nullable restore
#line 77 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                     \r\n\r\n                                </tbody>\r\n\r\n                            </table>\r\n                        </div>\r\n");
#nullable restore
#line 84 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-danger\">\r\n                            Stok Kartı Eklenmemiş.\r\n                        </div>\r\n");
#nullable restore
#line 90 "C:\Users\Samed\source\repos\StokTakipProgramı\StokTakipProgramı\Views\AlSat\StokSat.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
            </div>
            <!-- /.col -->
        </div>
        <!-- /.row -->
    </div>
    <!-- /.container-fluid -->
</section>
<!-- /.content -->
<!-- Page specific script -->
<script>
    $(function () {
        $('#example2').DataTable({
            ""paging"": true,
            ""lengthChange"": false,
            ""searching"": false,
            ""ordering"": true,
            ""info"": true,
            ""autoWidth"": false,
            ""responsive"": true,
        });
    });
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
