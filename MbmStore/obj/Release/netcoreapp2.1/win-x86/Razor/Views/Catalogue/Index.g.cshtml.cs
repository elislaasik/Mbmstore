#pragma checksum "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b6201079acd75b4b4dd949c3a3c7928da6ce9ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogue_Index), @"mvc.1.0.view", @"/Views/Catalogue/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalogue/Index.cshtml", typeof(AspNetCore.Views_Catalogue_Index))]
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
#line 4 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\_ViewImports.cshtml"
using MbmStore.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b6201079acd75b4b4dd949c3a3c7928da6ce9ef", @"/Views/Catalogue/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff7d904b8766a387727089c83b92a5782d19e7ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogue_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn-secondary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn-primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group pull-right m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::MbmStore.Infrastructure.PageLinkTagHelper __MbmStore_Infrastructure_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
  
    ViewData["Title"] = "Producs";

#line default
#line hidden
            BeginContext(73, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 7 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
 if (Model.Products.OfType<Book>().ToList().Count > 0)
{


#line default
#line hidden
            BeginContext(138, 75, true);
            WriteLiteral("    <div class=\"products\" style=\"clear:both\">\r\n        <h2>The Books</h2>\r\n");
            EndContext();
#line 12 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
         foreach (Book book in Model.Products.OfType<Book>().ToList())
        {
            

#line default
#line hidden
            BeginContext(309, 52, false);
#line 14 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
       Write(await Html.PartialAsync("_ProductSummaryBook", book));

#line default
#line hidden
            EndContext();
#line 14 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                                                                 
        }

#line default
#line hidden
            BeginContext(374, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 17 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
}

#line default
#line hidden
            BeginContext(389, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
 if (Model.Products.OfType<MusicCD>().ToList().Count > 0)
{

#line default
#line hidden
            BeginContext(453, 79, true);
            WriteLiteral("    <div class=\"products\" style=\"clear:both\">\r\n        <h2>The Music CDs</h2>\r\n");
            EndContext();
#line 23 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
         foreach (MusicCD cd in Model.Products.OfType<MusicCD>().ToList())
        {
            

#line default
#line hidden
            BeginContext(632, 53, false);
#line 25 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
       Write(await Html.PartialAsync("_ProductSummaryMusicCD", cd));

#line default
#line hidden
            EndContext();
#line 25 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                                                                  
        }

#line default
#line hidden
            BeginContext(698, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 28 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
}

#line default
#line hidden
            BeginContext(713, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 30 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
 if (Model.Products.OfType<Movie>().ToList().Count > 0)
{

#line default
#line hidden
            BeginContext(775, 76, true);
            WriteLiteral("    <div class=\"products\" style=\"clear:both\">\r\n        <h2>The Movies</h2>\r\n");
            EndContext();
#line 34 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
         foreach (Movie movie in Model.Products.OfType<Movie>().ToList())
        {
            

#line default
#line hidden
            BeginContext(950, 54, false);
#line 36 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
       Write(await Html.PartialAsync("_ProductSummaryMovie", movie));

#line default
#line hidden
            EndContext();
#line 36 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
                                                                   
        }

#line default
#line hidden
            BeginContext(1017, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 39 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1032, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1034, 271, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25bd65325fc840aabf8158d65b47c37e", async() => {
                BeginContext(1297, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __MbmStore_Infrastructure_PageLinkTagHelper = CreateTagHelper<global::MbmStore.Infrastructure.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__MbmStore_Infrastructure_PageLinkTagHelper);
#line 41 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
__MbmStore_Infrastructure_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __MbmStore_Infrastructure_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __MbmStore_Infrastructure_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 41 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
__MbmStore_Infrastructure_PageLinkTagHelper.PageClassesEnabled = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __MbmStore_Infrastructure_PageLinkTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __MbmStore_Infrastructure_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __MbmStore_Infrastructure_PageLinkTagHelper.PageClassNormal = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __MbmStore_Infrastructure_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__MbmStore_Infrastructure_PageLinkTagHelper.PageUrlValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("page-url-category", "MbmStore.Infrastructure.PageLinkTagHelper", "PageUrlValues"));
            }
#line 43 "C:\Users\jear\Dropbox\Eaaa-it\2018e\backend\projects\Exercises\Lesson07_MbmStore_solution\MbmStore\Views\Catalogue\Index.cshtml"
__MbmStore_Infrastructure_PageLinkTagHelper.PageUrlValues["category"] = Model.CurrentCategory;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-category", __MbmStore_Infrastructure_PageLinkTagHelper.PageUrlValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
