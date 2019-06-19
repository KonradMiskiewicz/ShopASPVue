#pragma checksum "C:\Users\n4dre\Desktop\SHOASPVUE\ShopASPVue\ShopASPVue\Shop\Pages\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c8f1c0e6be3b3919947ab4151f2ead36d352746"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Shop.Pages.Admin.Pages_Admin_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Index.cshtml", typeof(Shop.Pages.Admin.Pages_Admin_Index), null)]
namespace Shop.Pages.Admin
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c8f1c0e6be3b3919947ab4151f2ead36d352746", @"/Pages/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc731b762f80aec965b2cb36c6229f82c638ab7c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/admin/products.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\n4dre\Desktop\SHOASPVUE\ShopASPVue\ShopASPVue\Shop\Pages\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(84, 115, true);
            WriteLiteral("    <div id=\"app\" class=\"container\">\r\n        <div v-if=\"!editing\">\r\n            <button class=\"button is-success\" ");
            EndContext();
            BeginContext(200, 517, true);
            WriteLiteral(@"@click=""newProduct"">Create Product</button>
            <table class=""table"">
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Value</th>
                    <th></th>
                    <th></th>
                </tr>
                <tr v-for=""(product, index) in products"">
                    <td>{{product.id}}</td>
                    <td>{{product.name}}</td>
                    <td>{{product.value}}</td>
                    <td><a ");
            EndContext();
            BeginContext(718, 82, true);
            WriteLiteral("@click=\"editProduct(product.id, index)\">Edit</a></td>\r\n                    <td><a ");
            EndContext();
            BeginContext(801, 943, true);
            WriteLiteral(@"@click=""deleteProduct(product.id)"">Delete</a></td>
                </tr>
            </table>
        </div>

        <div v-else>
            <div class=""field"">
                <label class=""label"">Product name</label>
                <div class=""control"">
                    <input class=""input"" v-model=""productModel.name"" />
                </div>
            </div>
            <div class=""field"">
                <label class=""label"">Product description</label>
                <div class=""control"">
                    <input class=""input"" v-model=""productModel.description"" />
                </div>
            </div>
            <div class=""field"">
                <label class=""label"">Product value</label>
                <div class=""control"">
                    <input class=""input"" v-model=""productModel.value"" />
                </div>
            </div>
            <button class=""button is-success"" ");
            EndContext();
            BeginContext(1745, 118, true);
            WriteLiteral("@click=\"createProduct\" v-if=\"!productModel.id\">Create Product</button>\r\n            <button class=\"button is-warning\" ");
            EndContext();
            BeginContext(1864, 93, true);
            WriteLiteral("@click=\"updateProduct\" v-else>Update</button>\r\n            <button class=\"button is-warning\" ");
            EndContext();
            BeginContext(1958, 63, true);
            WriteLiteral("@click=\"cancel\">Cancel</button>\r\n        </div>\r\n    </div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2038, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2044, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36331aa5754047919b88a29757267641", async() => {
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
                EndContext();
                BeginContext(2090, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(2095, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.Pages.Admin.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Shop.Pages.Admin.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Shop.Pages.Admin.IndexModel>)PageContext?.ViewData;
        public Shop.Pages.Admin.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
