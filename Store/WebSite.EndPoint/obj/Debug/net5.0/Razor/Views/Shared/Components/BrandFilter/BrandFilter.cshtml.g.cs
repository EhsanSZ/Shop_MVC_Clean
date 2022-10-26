#pragma checksum "D:\MyProje\ASP.Net\Shop_MVC_Core\Store\WebSite.EndPoint\Views\Shared\Components\BrandFilter\BrandFilter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e11f1ea207ebb8b0859c6dd77ad6f7b655550a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BrandFilter_BrandFilter), @"mvc.1.0.view", @"/Views/Shared/Components/BrandFilter/BrandFilter.cshtml")]
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
#line 1 "D:\MyProje\ASP.Net\Shop_MVC_Core\Store\WebSite.EndPoint\Views\_ViewImports.cshtml"
using WebSite.EndPoint;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MyProje\ASP.Net\Shop_MVC_Core\Store\WebSite.EndPoint\Views\_ViewImports.cshtml"
using WebSite.EndPoint.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\MyProje\ASP.Net\Shop_MVC_Core\Store\WebSite.EndPoint\Views\Shared\Components\BrandFilter\BrandFilter.cshtml"
using Application.Catalogs.CatalogItems.CatalogItemServices;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e11f1ea207ebb8b0859c6dd77ad6f7b655550a1", @"/Views/Shared/Components/BrandFilter/BrandFilter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbd009ecef93b67a26d4c2022aef763916a9c9a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BrandFilter_BrandFilter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CatalogBrandDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("widget-content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\MyProje\ASP.Net\Shop_MVC_Core\Store\WebSite.EndPoint\Views\Shared\Components\BrandFilter\BrandFilter.cshtml"
  
    Layout = null;
    var BRANSID = Context.Request.Query["brandId"];


#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""widget widget-filter-options shadow-around"">
    <div class=""widget-title"">برند</div>
    <div class=""search-in-options form-element-row"">
        <div class=""form-element-with-icon"">
            <input type=""text"" class=""input-element"" placeholder=""جستجوی نام برند..."">
            <i class=""fad fa-file-search""></i>
        </div>
    </div>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e11f1ea207ebb8b0859c6dd77ad6f7b655550a15256", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 21 "D:\MyProje\ASP.Net\Shop_MVC_Core\Store\WebSite.EndPoint\Views\Shared\Components\BrandFilter\BrandFilter.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\MyProje\ASP.Net\Shop_MVC_Core\Store\WebSite.EndPoint\Views\Shared\Components\BrandFilter\BrandFilter.cshtml"
             if (BRANSID.ToList().Any(p => p == item.Id.ToString()))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <label class=\"container-checkbox\">\r\n                    ");
#nullable restore
#line 26 "D:\MyProje\ASP.Net\Shop_MVC_Core\Store\WebSite.EndPoint\Views\Shared\Components\BrandFilter\BrandFilter.cshtml"
               Write(item.Brand);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <input type=\"checkbox\" checked name=\"brandId\"");
                BeginWriteAttribute("value", " value=\"", 898, "\"", 914, 1);
#nullable restore
#line 27 "D:\MyProje\ASP.Net\Shop_MVC_Core\Store\WebSite.EndPoint\Views\Shared\Components\BrandFilter\BrandFilter.cshtml"
WriteAttributeValue("", 906, item.Id, 906, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onclick=\"submit();\">\r\n                    <span class=\"checkmark\"></span>\r\n                </label>\r\n");
#nullable restore
#line 30 "D:\MyProje\ASP.Net\Shop_MVC_Core\Store\WebSite.EndPoint\Views\Shared\Components\BrandFilter\BrandFilter.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <label class=\"container-checkbox\">\r\n                    ");
#nullable restore
#line 34 "D:\MyProje\ASP.Net\Shop_MVC_Core\Store\WebSite.EndPoint\Views\Shared\Components\BrandFilter\BrandFilter.cshtml"
               Write(item.Brand);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <input type=\"checkbox\" name=\"brandId\"");
                BeginWriteAttribute("value", " value=\"", 1207, "\"", 1223, 1);
#nullable restore
#line 35 "D:\MyProje\ASP.Net\Shop_MVC_Core\Store\WebSite.EndPoint\Views\Shared\Components\BrandFilter\BrandFilter.cshtml"
WriteAttributeValue("", 1215, item.Id, 1215, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onclick=\"submit();\">\r\n                    <span class=\"checkmark\"></span>\r\n                </label>\r\n");
#nullable restore
#line 38 "D:\MyProje\ASP.Net\Shop_MVC_Core\Store\WebSite.EndPoint\Views\Shared\Components\BrandFilter\BrandFilter.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\MyProje\ASP.Net\Shop_MVC_Core\Store\WebSite.EndPoint\Views\Shared\Components\BrandFilter\BrandFilter.cshtml"
             

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 42 "D:\MyProje\ASP.Net\Shop_MVC_Core\Store\WebSite.EndPoint\Views\Shared\Components\BrandFilter\BrandFilter.cshtml"
         foreach (var queryString in Context.Request.Query.Where(p => p.Key != "brandId").ToList())
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1500, "\"", 1523, 1);
#nullable restore
#line 44 "D:\MyProje\ASP.Net\Shop_MVC_Core\Store\WebSite.EndPoint\Views\Shared\Components\BrandFilter\BrandFilter.cshtml"
WriteAttributeValue("", 1507, queryString.Key, 1507, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1524, "\"", 1550, 1);
#nullable restore
#line 44 "D:\MyProje\ASP.Net\Shop_MVC_Core\Store\WebSite.EndPoint\Views\Shared\Components\BrandFilter\BrandFilter.cshtml"
WriteAttributeValue("", 1532, queryString.Value, 1532, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 45 "D:\MyProje\ASP.Net\Shop_MVC_Core\Store\WebSite.EndPoint\Views\Shared\Components\BrandFilter\BrandFilter.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CatalogBrandDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
