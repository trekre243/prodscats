#pragma checksum "C:\Users\tkrec\Downloads\c#\ProdsCats\Views\Home\SpecCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2d6a489a4da52a3ae22e05cc500ae05592868d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SpecCategory), @"mvc.1.0.view", @"/Views/Home/SpecCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SpecCategory.cshtml", typeof(AspNetCore.Views_Home_SpecCategory))]
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
#line 2 "C:\Users\tkrec\Downloads\c#\ProdsCats\Views\_ViewImports.cshtml"
using ProdsCats.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2d6a489a4da52a3ae22e05cc500ae05592868d6", @"/Views/Home/SpecCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ee4d78f167240efe4f85909ca8a920557e5a78b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SpecCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/addproduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 71, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col s12 center-align\">\r\n        <h3>");
            EndContext();
            BeginContext(72, 15, false);
#line 3 "C:\Users\tkrec\Downloads\c#\ProdsCats\Views\Home\SpecCategory.cshtml"
       Write(ViewBag.CatName);

#line default
#line hidden
            EndContext();
            BeginContext(87, 220, true);
            WriteLiteral("</h3>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col s12\">\r\n        <a href=\"/categories\">Back</a>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col s6\">\r\n        <h4>Products:</h4>\r\n        <ul>\r\n");
            EndContext();
#line 15 "C:\Users\tkrec\Downloads\c#\ProdsCats\Views\Home\SpecCategory.cshtml"
             foreach(var product in ViewBag.CategoryAssociations)
            {

#line default
#line hidden
            BeginContext(389, 20, true);
            WriteLiteral("                <li>");
            EndContext();
            BeginContext(410, 20, false);
#line 17 "C:\Users\tkrec\Downloads\c#\ProdsCats\Views\Home\SpecCategory.cshtml"
               Write(product.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(430, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 18 "C:\Users\tkrec\Downloads\c#\ProdsCats\Views\Home\SpecCategory.cshtml"
            }

#line default
#line hidden
            BeginContext(452, 61, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n    <div class=\"col s6\">\r\n        ");
            EndContext();
            BeginContext(513, 686, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2d6a489a4da52a3ae22e05cc500ae05592868d65558", async() => {
                BeginContext(554, 52, true);
                WriteLiteral("\r\n            <input name=\"CategoryId\" type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 606, "\"", 633, 1);
#line 23 "C:\Users\tkrec\Downloads\c#\ProdsCats\Views\Home\SpecCategory.cshtml"
WriteAttributeValue("", 614, ViewBag.CategoryId, 614, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(634, 149, true);
                WriteLiteral(">\r\n            <div class=\"input-field col s12\">\r\n                <p>Product</p>\r\n                <select name=\"ProductId\" class=\"browser-default\">\r\n");
                EndContext();
#line 27 "C:\Users\tkrec\Downloads\c#\ProdsCats\Views\Home\SpecCategory.cshtml"
                     foreach(var product in ViewBag.ChooseProducts)
                    {

#line default
#line hidden
                BeginContext(875, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(899, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2d6a489a4da52a3ae22e05cc500ae05592868d66906", async() => {
                    BeginContext(935, 12, false);
#line 29 "C:\Users\tkrec\Downloads\c#\ProdsCats\Views\Home\SpecCategory.cshtml"
                                                      Write(product.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 29 "C:\Users\tkrec\Downloads\c#\ProdsCats\Views\Home\SpecCategory.cshtml"
                           WriteLiteral(product.ProductId);

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
                BeginContext(956, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 30 "C:\Users\tkrec\Downloads\c#\ProdsCats\Views\Home\SpecCategory.cshtml"
                    }

#line default
#line hidden
                BeginContext(981, 211, true);
                WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\"input-field col s12\">\r\n                <button type=\"submit\" class=\"waves-effect waves-light btn\">Add</button>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1199, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591