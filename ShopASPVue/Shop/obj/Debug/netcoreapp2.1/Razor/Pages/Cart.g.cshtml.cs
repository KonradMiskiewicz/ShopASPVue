#pragma checksum "C:\Users\n4dre\Desktop\SHOASPVUE\ShopASPVue\ShopASPVue\Shop\Pages\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccee060e73b9e789c1f3a61ae80cffb559435597"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Shop.Pages.Pages_Cart), @"mvc.1.0.razor-page", @"/Pages/Cart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Cart.cshtml", typeof(Shop.Pages.Pages_Cart), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccee060e73b9e789c1f3a61ae80cffb559435597", @"/Pages/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc731b762f80aec965b2cb36c6229f82c638ab7c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Shop.Pages.Pages_Cart.__Generated__CartViewComponentTagHelper __CartViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 7, true);
            WriteLiteral("<div>\r\n");
            EndContext();
#line 6 "C:\Users\n4dre\Desktop\SHOASPVUE\ShopASPVue\ShopASPVue\Shop\Pages\Cart.cshtml"
     foreach (var product in Model.CartList)
    {

#line default
#line hidden
            BeginContext(92, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(100, 12, false);
#line 8 "C:\Users\n4dre\Desktop\SHOASPVUE\ShopASPVue\ShopASPVue\Shop\Pages\Cart.cshtml"
  Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(112, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(126, 13, false);
#line 9 "C:\Users\n4dre\Desktop\SHOASPVUE\ShopASPVue\ShopASPVue\Shop\Pages\Cart.cshtml"
  Write(product.Value);

#line default
#line hidden
            EndContext();
            BeginContext(139, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(153, 15, false);
#line 10 "C:\Users\n4dre\Desktop\SHOASPVUE\ShopASPVue\ShopASPVue\Shop\Pages\Cart.cshtml"
  Write(product.Quality);

#line default
#line hidden
            EndContext();
            BeginContext(168, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(182, 15, false);
#line 11 "C:\Users\n4dre\Desktop\SHOASPVUE\ShopASPVue\ShopASPVue\Shop\Pages\Cart.cshtml"
  Write(product.StockId);

#line default
#line hidden
            EndContext();
            BeginContext(197, 18, true);
            WriteLiteral("</p>\r\n    <hr />\r\n");
            EndContext();
#line 13 "C:\Users\n4dre\Desktop\SHOASPVUE\ShopASPVue\ShopASPVue\Shop\Pages\Cart.cshtml"
    }

#line default
#line hidden
            BeginContext(222, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            BeginContext(232, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:cart", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bec7808a809544e29f00dc9080cdf8a4", async() => {
            }
            );
            __CartViewComponentTagHelper = CreateTagHelper<global::Shop.Pages.Pages_Cart.__Generated__CartViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__CartViewComponentTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("Small");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __CartViewComponentTagHelper.view = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("view", __CartViewComponentTagHelper.view, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(264, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CartModel>)PageContext?.ViewData;
        public CartModel Model => ViewData.Model;
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:cart")]
        public class __Generated__CartViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
            public __Generated__CartViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                _helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.String view { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
            {
                (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var content = await _helper.InvokeAsync("Cart", new { view });
                output.TagName = null;
                output.Content.SetHtmlContent(content);
            }
        }
    }
}
#pragma warning restore 1591
