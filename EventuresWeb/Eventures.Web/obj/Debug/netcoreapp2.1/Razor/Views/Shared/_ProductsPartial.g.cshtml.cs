#pragma checksum "C:\Users\Admin\Desktop\Eventures\Eventures.Web\Views\Shared\_ProductsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "518e19e740351c610b4b2c90f1f9c67c49f0e7bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductsPartial), @"mvc.1.0.view", @"/Views/Shared/_ProductsPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ProductsPartial.cshtml", typeof(AspNetCore.Views_Shared__ProductsPartial))]
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
#line 1 "C:\Users\Admin\Desktop\Eventures\Eventures.Web\Views\_ViewImports.cshtml"
using Eventures.Web;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\Eventures\Eventures.Web\Views\_ViewImports.cshtml"
using Eventures.Web.Models;

#line default
#line hidden
#line 3 "C:\Users\Admin\Desktop\Eventures\Eventures.Web\Views\_ViewImports.cshtml"
using Eventures.Models;

#line default
#line hidden
#line 4 "C:\Users\Admin\Desktop\Eventures\Eventures.Web\Views\_ViewImports.cshtml"
using Eventures.Models.ViewModels.Product;

#line default
#line hidden
#line 5 "C:\Users\Admin\Desktop\Eventures\Eventures.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"518e19e740351c610b4b2c90f1f9c67c49f0e7bc", @"/Views/Shared/_ProductsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e05227e9c14483ea15cd8bcc621abd25f79d4ef6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Admin\Desktop\Eventures\Eventures.Web\Views\Shared\_ProductsPartial.cshtml"
  
    ViewData["Title"] = "_ProductsPartial";

#line default
#line hidden
            BeginContext(94, 101, true);
            WriteLiteral("\r\n<div class=\"container-fluid product-holder\">\r\n    <div class=\"row d-flex justify-content-around\">\r\n");
            EndContext();
#line 8 "C:\Users\Admin\Desktop\Eventures\Eventures.Web\Views\Shared\_ProductsPartial.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(244, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(256, 794, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8402a6b00f54317ae98b5867ba4a5cb", async() => {
                BeginContext(346, 138, true);
                WriteLiteral("\r\n                <div class=\"product p-1 chushka-bg-color rounded-top rounded-bottom\">\r\n                    <h5 class=\"text-center mt-3\">");
                EndContext();
                BeginContext(485, 9, false);
#line 12 "C:\Users\Admin\Desktop\Eventures\Eventures.Web\Views\Shared\_ProductsPartial.cshtml"
                                            Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(494, 113, true);
                WriteLiteral("</h5>\r\n                    <hr class=\"hr-1 bg-white\" />\r\n                    <p class=\"text-white text-center\">\r\n");
                EndContext();
#line 15 "C:\Users\Admin\Desktop\Eventures\Eventures.Web\Views\Shared\_ProductsPartial.cshtml"
                         if (item.Description.Length > 50)
                        {
                            item.Description = item.Description.Substring(0, 50) + "...";
                        }

#line default
#line hidden
                BeginContext(812, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(837, 16, false);
#line 19 "C:\Users\Admin\Desktop\Eventures\Eventures.Web\Views\Shared\_ProductsPartial.cshtml"
                   Write(item.Description);

#line default
#line hidden
                EndContext();
                BeginContext(853, 139, true);
                WriteLiteral("\r\n                    </p>\r\n                    <hr class=\"hr-1 bg-white\" />\r\n                    <h6 class=\"text-center text-white mb-3\">$");
                EndContext();
                BeginContext(993, 10, false);
#line 22 "C:\Users\Admin\Desktop\Eventures\Eventures.Web\Views\Shared\_ProductsPartial.cshtml"
                                                        Write(item.Price);

#line default
#line hidden
                EndContext();
                BeginContext(1003, 43, true);
                WriteLiteral("</h6>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 10 "C:\Users\Admin\Desktop\Eventures\Eventures.Web\Views\Shared\_ProductsPartial.cshtml"
                                                               WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1050, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 25 "C:\Users\Admin\Desktop\Eventures\Eventures.Web\Views\Shared\_ProductsPartial.cshtml"
        }

#line default
#line hidden
            BeginContext(1063, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591