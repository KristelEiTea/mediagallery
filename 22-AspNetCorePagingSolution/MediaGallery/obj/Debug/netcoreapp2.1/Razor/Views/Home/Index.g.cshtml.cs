#pragma checksum "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bce37ef9632cd8841b1b27574a90bbc09ad64c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\_ViewImports.cshtml"
using MediaGallery;

#line default
#line hidden
#line 2 "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\_ViewImports.cshtml"
using MediaGallery.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bce37ef9632cd8841b1b27574a90bbc09ad64c9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d6531bab7f76b3f92639632e531729d736eaa2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FrontPageModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Sidebar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ItemsList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(68, 151, true);
            WriteLiteral("\r\n<div class=\"main\">\r\n    <div class=\"container\">\r\n        <!-- BEGIN SIDEBAR & CONTENT -->\r\n        <div class=\"row margin-bottom-40\">\r\n\r\n            ");
            EndContext();
            BeginContext(219, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8ea1a257fa444707beb14f5842635394", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(246, 107, true);
            WriteLiteral("\r\n\r\n            <!-- BEGIN CONTENT -->\r\n            <div class=\"col-md-9 col-sm-7\">\r\n                <ul>\r\n");
            EndContext();
#line 16 "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\Home\Index.cshtml"
                 foreach(var photo in Model.AllPhotos.Results)
                {

#line default
#line hidden
            BeginContext(436, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(461, 8, false);
#line 18 "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\Home\Index.cshtml"
                   Write(photo.Id);

#line default
#line hidden
            EndContext();
            BeginContext(469, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(473, 15, false);
#line 18 "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\Home\Index.cshtml"
                               Write(photo.Thumbnail);

#line default
#line hidden
            EndContext();
            BeginContext(488, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 19 "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(514, 102, true);
            WriteLiteral("                </ul>\r\n\r\n                <!-- SIIA ASEMELE PAGER COMPONENT -->\r\n                <ul>\r\n");
            EndContext();
#line 24 "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\Home\Index.cshtml"
                     for(var i = 1; i <= Model.AllPhotos.PageCount; i++)
                    {

#line default
#line hidden
            BeginContext(713, 53, true);
            WriteLiteral("                        <li style=\"display:inline\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 766, "\"", 811, 1);
#line 26 "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\Home\Index.cshtml"
WriteAttributeValue("", 773, Url.Action("Index", new { page = i }), 773, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(812, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(814, 1, false);
#line 26 "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\Home\Index.cshtml"
                                                                                               Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(815, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 27 "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(849, 80, true);
            WriteLiteral("                </ul>\r\n\r\n                <h2>New photos</h2>\r\n\r\n                ");
            EndContext();
            BeginContext(929, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f65e446dfc0e431fb916bbec0ebb1428", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 32 "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.NewPhotos;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(983, 63, true);
            WriteLiteral("\r\n\r\n                <h2>Popular photos</h2>\r\n\r\n                ");
            EndContext();
            BeginContext(1046, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "05556cf3721a4d568bfc56edf492b817", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 36 "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.PopularPhotos;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1104, 1006, true);
            WriteLiteral(@"

                <!-- BEGIN PAGINATOR -->
                <div class=""row"">
                    <div class=""col-md-4 col-sm-4 items-info"">Items 1 to 9 of 10 total</div>
                    <div class=""col-md-8 col-sm-8"">
                        <ul class=""pagination pull-right"">
                            <li><a href=""javascript:;"">&laquo;</a></li>
                            <li><a href=""javascript:;"">1</a></li>
                            <li><span>2</span></li>
                            <li><a href=""javascript:;"">3</a></li>
                            <li><a href=""javascript:;"">4</a></li>
                            <li><a href=""javascript:;"">5</a></li>
                            <li><a href=""javascript:;"">&raquo;</a></li>
                        </ul>
                    </div>
                </div>
                <!-- END PAGINATOR -->
            </div>
            <!-- END CONTENT -->
        </div>
        <!-- END SIDEBAR & CONTENT -->
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FrontPageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
