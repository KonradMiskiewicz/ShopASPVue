#pragma checksum "C:\Users\n4dre\Desktop\SHOASPVUE\ShopASPVue\ShopASPVue\Shop\Pages\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb4079b3f312e795d0639b0386d2ed13c85e71cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Shop.Pages.Pages_Product), @"mvc.1.0.razor-page", @"/Pages/Product.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Product.cshtml", typeof(Shop.Pages.Pages_Product), @"{name}")]
namespace Shop.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\n4dre\Desktop\SHOASPVUE\ShopASPVue\ShopASPVue\Shop\Pages\_ViewImports.cshtml"
using Shop;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{name}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb4079b3f312e795d0639b0386d2ed13c85e71cf", @"/Pages/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc731b762f80aec965b2cb36c6229f82c638ab7c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Product : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 14, true);
            WriteLiteral("<div>\r\n    <p>");
            EndContext();
            BeginContext(59, 18, false);
#line 6 "C:\Users\n4dre\Desktop\SHOASPVUE\ShopASPVue\ShopASPVue\Shop\Pages\Product.cshtml"
  Write(Model.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(77, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(91, 25, false);
#line 7 "C:\Users\n4dre\Desktop\SHOASPVUE\ShopASPVue\ShopASPVue\Shop\Pages\Product.cshtml"
  Write(Model.Product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(116, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(130, 19, false);
#line 8 "C:\Users\n4dre\Desktop\SHOASPVUE\ShopASPVue\ShopASPVue\Shop\Pages\Product.cshtml"
  Write(Model.Product.Value);

#line default
#line hidden
            EndContext();
            BeginContext(149, 27, true);
            WriteLiteral("</p>\r\n    <div>\r\n\r\n        ");
            EndContext();
            BeginContext(176, 422, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a849b4deba104bf28bb343fb8141b229", async() => {
                BeginContext(196, 54, true);
                WriteLiteral("\r\n\r\n\r\n            <label>Stock</label>\r\n\r\n            ");
                EndContext();
                BeginContext(250, 225, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5846d87563ab4125badf637ff3a85eca", async() => {
                    BeginContext(290, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 17 "C:\Users\n4dre\Desktop\SHOASPVUE\ShopASPVue\ShopASPVue\Shop\Pages\Product.cshtml"
                 foreach (var p in Model.Product.Stock)
                {

#line default
#line hidden
                    BeginContext(368, 20, true);
                    WriteLiteral("                    ");
                    EndContext();
                    BeginContext(388, 45, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "870bb5cba9ab4b89b95ad4768320d620", async() => {
                        BeginContext(411, 13, false);
#line 19 "C:\Users\n4dre\Desktop\SHOASPVUE\ShopASPVue\ShopASPVue\Shop\Pages\Product.cshtml"
                                     Write(p.Description);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 19 "C:\Users\n4dre\Desktop\SHOASPVUE\ShopASPVue\ShopASPVue\Shop\Pages\Product.cshtml"
                       WriteLiteral(p.Id);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(433, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 20 "C:\Users\n4dre\Desktop\SHOASPVUE\ShopASPVue\ShopASPVue\Shop\Pages\Product.cshtml"
                }

#line default
#line hidden
                    BeginContext(454, 12, true);
                    WriteLiteral("            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 16 "C:\Users\n4dre\Desktop\SHOASPVUE\ShopASPVue\ShopASPVue\Shop\Pages\Product.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CartViewModel.StockId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(475, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(489, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7160693ab69b4974a7de0ebb02e75200", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 22 "C:\Users\n4dre\Desktop\SHOASPVUE\ShopASPVue\ShopASPVue\Shop\Pages\Product.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CartViewModel.Quality);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(530, 61, true);
                WriteLiteral("\r\n            <button type=\"submit\">Submit</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(598, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(621, 35, false);
#line 27 "C:\Users\n4dre\Desktop\SHOASPVUE\ShopASPVue\ShopASPVue\Shop\Pages\Product.cshtml"
Write(await Component.InvokeAsync("Cart"));

#line default
#line hidden
            EndContext();
            BeginContext(656, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProductModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProductModel>)PageContext?.ViewData;
        public ProductModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
