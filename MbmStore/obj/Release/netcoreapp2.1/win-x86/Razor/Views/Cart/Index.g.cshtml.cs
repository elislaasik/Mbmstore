#pragma checksum "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "047efb321d6d599ebca037372ed283e89bbe798e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
#line 3 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\_ViewImports.cshtml"
using MbmStore.Models;

#line default
#line hidden
#line 2 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Cart\Index.cshtml"
using MbmStore.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"047efb321d6d599ebca037372ed283e89bbe798e", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff7d904b8766a387727089c83b92a5782d19e7ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(118, 296, true);
            WriteLiteral(@"<h2>Your cart</h2>
<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th>Quantity</th>
            <th>Item</th>
            <th class=""text-right"">Price</th>
            <th class=""text-right"">Subtotal</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 15 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Cart\Index.cshtml"
         foreach (var line in Model.Cart.Lines)
        {

#line default
#line hidden
            BeginContext(474, 58, true);
            WriteLiteral("            <tr>\r\n                <td class=\"text-center\">");
            EndContext();
            BeginContext(533, 13, false);
#line 18 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Cart\Index.cshtml"
                                   Write(line.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(546, 45, true);
            WriteLiteral("</td>\r\n                <td class=\"text-left\">");
            EndContext();
            BeginContext(592, 18, false);
#line 19 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Cart\Index.cshtml"
                                 Write(line.Product.Title);

#line default
#line hidden
            EndContext();
            BeginContext(610, 46, true);
            WriteLiteral("</td>\r\n                <td class=\"text-right\">");
            EndContext();
            BeginContext(657, 32, false);
#line 20 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Cart\Index.cshtml"
                                  Write(line.Product.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(689, 68, true);
            WriteLiteral("</td>\r\n                <td class=\"text-right\">\r\n                    ");
            EndContext();
            BeginContext(759, 50, false);
#line 22 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Cart\Index.cshtml"
                Write((line.Quantity * line.Product.Price).ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(810, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(877, 479, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdbdd08ca8fd43c5bce156518c17722a", async() => {
                BeginContext(925, 63, true);
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"ProductID\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                               value=\"", 988, "\"", 1051, 1);
#line 27 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1028, line.Product.ProductID, 1028, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1052, 66, true);
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"returnUrl\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                               value=\"", 1118, "\"", 1174, 1);
#line 29 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1158, Model.ReturnUrl, 1158, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1175, 174, true);
                WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"btn btn-sm btn-danger\">\r\n                            Remove\r\n                        </button>\r\n                    ");
                EndContext();
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1356, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 36 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Cart\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1411, 154, true);
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"3\" class=\"text-right\">Total:</td>\r\n            <td class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(1566, 44, false);
#line 42 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Cart\Index.cshtml"
           Write(Model.Cart.ComputeTotalValue().ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1610, 117, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n<div class=\"text-center\">\r\n    <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1727, "\"", 1750, 1);
#line 48 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1734, Model.ReturnUrl, 1734, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1751, 28, true);
            WriteLiteral(">Continue shopping</a>\r\n    ");
            EndContext();
            BeginContext(1779, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "721f522584554525acd03ade465f5206", async() => {
                BeginContext(1851, 24, true);
                WriteLiteral("\r\n        Checkout\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1879, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591