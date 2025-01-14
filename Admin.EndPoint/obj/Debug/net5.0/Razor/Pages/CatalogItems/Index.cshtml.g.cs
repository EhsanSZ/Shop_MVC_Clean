#pragma checksum "D:\MyProje\ASP.Net\Shop_MVC_Core\Admin.EndPoint\Pages\CatalogItems\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c74781ee6b03f82c35e5672dff39ce3c73ed71a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Admin.EndPoint.Pages.CatalogItems.Pages_CatalogItems_Index), @"mvc.1.0.razor-page", @"/Pages/CatalogItems/Index.cshtml")]
namespace Admin.EndPoint.Pages.CatalogItems
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
#line 1 "D:\MyProje\ASP.Net\Shop_MVC_Core\Admin.EndPoint\Pages\_ViewImports.cshtml"
using Admin.EndPoint;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c74781ee6b03f82c35e5672dff39ce3c73ed71a4", @"/Pages/CatalogItems/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"163d608d1efa361df4f75eec424fdfdc06c777fe", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_CatalogItems_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""content-wrapper"">
    <div class=""container-fluid"">
        <!-- Zero configuration table -->
        <section id=""configuration"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card"">

                        <div class=""card-body collapse show"">
                            <div class=""card-block card-dashboard"">
                                <p class=""card-text"">لیست کاتالوگ ها</p>
                                <div id=""DataTables_Table_0_wrapper"" class=""dataTables_wrapper container-fluid dt-bootstrap4"">
                                    <div class=""col-sm-12"">
                                        <table class=""table table-striped table-bordered zero-configuration dataTable"" id=""DataTables_Table_0"" role=""grid"" aria-describedby=""DataTables_Table_0_info"">
                                            <thead>
                                                <tr role=""row"">
                                                 ");
            WriteLiteral(@"   <th class=""sorting_asc"">شناسه</th>
                                                    <th class=""sorting_asc"">نام</th>
                                                    <th class=""sorting_asc"">دسته بندی</th>
                                                    <th class=""sorting_asc"">برند </th>
                                                    <th class=""sorting_asc"">قیمت </th>
                                                    <th class=""sorting_asc"">موجودی </th>
                                                    <th class=""sorting_asc""> حداقل برای سفارش مجدد </th>
                                                    <th class=""sorting_asc""> حداکثر موجودی</th>
                                                    <th class=""sorting_asc""> </th>
                                                </tr>
                                            </thead>
                                            <tbody>

");
#nullable restore
#line 36 "D:\MyProje\ASP.Net\Shop_MVC_Core\Admin.EndPoint\Pages\CatalogItems\Index.cshtml"
                                                 foreach (var item in Model.CatalogItems.Data)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr role=\"row\">\r\n                                                        <td>");
#nullable restore
#line 39 "D:\MyProje\ASP.Net\Shop_MVC_Core\Admin.EndPoint\Pages\CatalogItems\Index.cshtml"
                                                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 40 "D:\MyProje\ASP.Net\Shop_MVC_Core\Admin.EndPoint\Pages\CatalogItems\Index.cshtml"
                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 41 "D:\MyProje\ASP.Net\Shop_MVC_Core\Admin.EndPoint\Pages\CatalogItems\Index.cshtml"
                                                       Write(item.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 42 "D:\MyProje\ASP.Net\Shop_MVC_Core\Admin.EndPoint\Pages\CatalogItems\Index.cshtml"
                                                       Write(item.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 43 "D:\MyProje\ASP.Net\Shop_MVC_Core\Admin.EndPoint\Pages\CatalogItems\Index.cshtml"
                                                       Write(item.Price.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 44 "D:\MyProje\ASP.Net\Shop_MVC_Core\Admin.EndPoint\Pages\CatalogItems\Index.cshtml"
                                                       Write(item.AvailableStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 45 "D:\MyProje\ASP.Net\Shop_MVC_Core\Admin.EndPoint\Pages\CatalogItems\Index.cshtml"
                                                       Write(item.RestockThreshold);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 46 "D:\MyProje\ASP.Net\Shop_MVC_Core\Admin.EndPoint\Pages\CatalogItems\Index.cshtml"
                                                       Write(item.MaxStockThreshold);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                                        <td>
                                                            <a class=""btn btn-danger"">حذف</a>
                                                            <a class=""btn btn-warning"">ویرایش</a>
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c74781ee6b03f82c35e5672dff39ce3c73ed71a49147", async() => {
                WriteLiteral(" جزئیات");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                        </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 53 "D:\MyProje\ASP.Net\Shop_MVC_Core\Admin.EndPoint\Pages\CatalogItems\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                    </div>
                                </div>


                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Admin.EndPoint.Pages.CatalogItems.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Admin.EndPoint.Pages.CatalogItems.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Admin.EndPoint.Pages.CatalogItems.IndexModel>)PageContext?.ViewData;
        public Admin.EndPoint.Pages.CatalogItems.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
