#pragma checksum "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\Home\Folder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d165f9eaec9f87143ef34d46ef3c08b34d2bf3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Folder), @"mvc.1.0.view", @"/Views/Home/Folder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Folder.cshtml", typeof(AspNetCore.Views_Home_Folder))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d165f9eaec9f87143ef34d46ef3c08b34d2bf3b", @"/Views/Home/Folder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d6531bab7f76b3f92639632e531729d736eaa2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Folder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MediaGallery.Data.MediaFolder>
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
#line 2 "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\Home\Folder.cshtml"
  
    ViewData["Title"] = "Folder";

#line default
#line hidden
            BeginContext(80, 48, true);
            WriteLiteral("\r\n<!-- Core CSS file -->\r\n<link rel=\"stylesheet\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 128, "\"", 182, 1);
#line 7 "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\Home\Folder.cshtml"
WriteAttributeValue("", 135, Url.Content("~/lib/photoswipe/photoswipe.css"), 135, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(183, 253, true);
            WriteLiteral(">\r\n\r\n<!-- Skin CSS file (styling of UI - buttons, caption, etc.)\r\n     In the folder of skin CSS file there are also:\r\n     - .png and .svg icons sprite,\r\n     - preloader.gif (for browsers that do not support CSS animations) -->\r\n<link rel=\"stylesheet\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 436, "\"", 505, 1);
#line 13 "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\Home\Folder.cshtml"
WriteAttributeValue("", 443, Url.Content("~/lib/photoswipe/default-skin/default-skin.css"), 443, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(506, 154, true);
            WriteLiteral(">\r\n\r\n<div class=\"main\">\r\n    <div class=\"container\">\r\n        <!-- BEGIN SIDEBAR & CONTENT -->\r\n        <div class=\"row margin-bottom-40\">\r\n\r\n            ");
            EndContext();
            BeginContext(660, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "094590b284e4410fa422a45954369af1", async() => {
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
            BeginContext(687, 105, true);
            WriteLiteral("\r\n\r\n            <!-- BEGIN CONTENT -->\r\n            <div class=\"col-md-9 col-sm-7\">\r\n                <h2>");
            EndContext();
            BeginContext(793, 11, false);
#line 24 "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\Home\Folder.cshtml"
               Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(804, 25, true);
            WriteLiteral("</h2>\r\n\r\n                ");
            EndContext();
            BeginContext(829, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b9b7839660214f81a0276cba1042f3a4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 26 "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\Home\Folder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Items;

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
            BeginContext(879, 179, true);
            WriteLiteral("\r\n\r\n                <!-- PAGER SIIA KOHTA -->\r\n            </div>\r\n            <!-- END CONTENT -->\r\n        </div>\r\n        <!-- END SIDEBAR & CONTENT -->\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1076, 40, true);
                WriteLiteral("\r\n    <!-- Core JS file -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1116, "\"", 1172, 1);
#line 38 "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\Home\Folder.cshtml"
WriteAttributeValue("", 1122, Url.Content("~/lib/photoswipe/photoswipe.min.js"), 1122, 50, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1173, 50, true);
                WriteLiteral("></script>\r\n\r\n    <!-- UI JS file -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1223, "\"", 1290, 1);
#line 41 "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\Home\Folder.cshtml"
WriteAttributeValue("", 1229, Url.Content("~/lib/photoswipe/photoswipe-ui-default.min.js"), 1229, 61, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1291, 228, true);
                WriteLiteral("></script>\r\n\r\n    <script>\r\n        jQuery(document).ready(function () {\r\n            return;\r\n            var pswpElement = document.querySelectorAll(\'.pswp\')[0];\r\n\r\n            // build items array\r\n            var items = [\r\n");
                EndContext();
#line 50 "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\Home\Folder.cshtml"
                 foreach(var photo in Model.Items.OfType<MediaGallery.Data.Photo>())
                {
                    

#line default
#line hidden
                BeginContext(1650, 56, true);
                WriteLiteral("\r\n                    {\r\n                        src: \'/");
                EndContext();
                BeginContext(1707, 14, false);
#line 54 "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\Home\Folder.cshtml"
                          Write(photo.FileName);

#line default
#line hidden
                EndContext();
                BeginContext(1721, 113, true);
                WriteLiteral("\',\r\n                        w: 600,\r\n                        h: 800\r\n                    },\r\n                    ");
                EndContext();
#line 58 "D:\#Games and Apps\GITHUB\Polykas2018\22-AspNetCorePagingSolution\MediaGallery\Views\Home\Folder.cshtml"
                           
                }

#line default
#line hidden
                BeginContext(1862, 755, true);
                WriteLiteral(@"                {
                    src: 'https://placekitten.com/600/400',
                    w: 600,
                    h: 800
                },
                {
                    src: 'https://placekitten.com/1200/900',
                    w: 1200,
                    h: 900
                }

            ];

            // define options (if needed)
            var options = {
                // optionName: 'option value'
                // for example:
                index: 0 // start at first slide
            };

            // Initializes and opens PhotoSwipe
            var gallery = new PhotoSwipe(pswpElement, PhotoSwipeUI_Default, items, options);
            gallery.init();
        });
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MediaGallery.Data.MediaFolder> Html { get; private set; }
    }
}
#pragma warning restore 1591
