#pragma checksum "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Post\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9444a4ac0790f60aa15489e5cb519199a083333"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Delete), @"mvc.1.0.view", @"/Views/Post/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Delete.cshtml", typeof(AspNetCore.Views_Post_Delete))]
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
#line 1 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\_ViewImports.cshtml"
using ConestogaCarpool;

#line default
#line hidden
#line 2 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\_ViewImports.cshtml"
using ConestogaCarpool.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9444a4ac0790f60aa15489e5cb519199a083333", @"/Views/Post/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bcb33f09722f6e897bb3047affcb0f70986625b", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConestogaCarpool.Models.Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnAllShared"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Post\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(128, 243, true);
            WriteLiteral("<div class=\"allBodyLeft\">\r\n    <div class=\"transparentBack\">\r\n        <h2>Delete</h2>\r\n\r\n        <h3>Are you sure you want to delete this post?</h3>\r\n        <div>\r\n            <hr />\r\n            <label class=\"detailLabels\">\r\n                ");
            EndContext();
            BeginContext(372, 47, false);
#line 15 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Post\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Destination));

#line default
#line hidden
            EndContext();
            BeginContext(419, 61, true);
            WriteLiteral(":\r\n            </label>\r\n            <label id=\"textLabels\"> ");
            EndContext();
            BeginContext(481, 43, false);
#line 17 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Post\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.Destination));

#line default
#line hidden
            EndContext();
            BeginContext(524, 90, true);
            WriteLiteral("</label>\r\n            <br />\r\n\r\n            <label class=\"detailLabels\">\r\n                ");
            EndContext();
            BeginContext(615, 44, false);
#line 21 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Post\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(659, 60, true);
            WriteLiteral(":\r\n            </label>\r\n            <label id=\"textLabels\">");
            EndContext();
            BeginContext(720, 40, false);
#line 23 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Post\Delete.cshtml"
                              Write(Html.DisplayFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(760, 90, true);
            WriteLiteral("</label>\r\n            <br />\r\n\r\n            <label class=\"detailLabels\">\r\n                ");
            EndContext();
            BeginContext(851, 40, false);
#line 27 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Post\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(891, 60, true);
            WriteLiteral(":\r\n            </label>\r\n            <label id=\"textLabels\">");
            EndContext();
            BeginContext(952, 36, false);
#line 29 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Post\Delete.cshtml"
                              Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(988, 90, true);
            WriteLiteral("</label>\r\n            <br />\r\n\r\n            <label class=\"detailLabels\">\r\n                ");
            EndContext();
            BeginContext(1079, 40, false);
#line 33 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Post\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Time));

#line default
#line hidden
            EndContext();
            BeginContext(1119, 60, true);
            WriteLiteral(":\r\n            </label>\r\n            <label id=\"textLabels\">");
            EndContext();
            BeginContext(1180, 36, false);
#line 35 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Post\Delete.cshtml"
                              Write(Html.DisplayFor(model => model.Time));

#line default
#line hidden
            EndContext();
            BeginContext(1216, 90, true);
            WriteLiteral("</label>\r\n            <br />\r\n\r\n            <label class=\"detailLabels\">\r\n                ");
            EndContext();
            BeginContext(1307, 42, false);
#line 39 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Post\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Driver));

#line default
#line hidden
            EndContext();
            BeginContext(1349, 60, true);
            WriteLiteral(":\r\n            </label>\r\n            <label id=\"textLabels\">");
            EndContext();
            BeginContext(1410, 47, false);
#line 41 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Post\Delete.cshtml"
                              Write(Html.DisplayFor(model => model.Driver.DriverId));

#line default
#line hidden
            EndContext();
            BeginContext(1457, 90, true);
            WriteLiteral("</label>\r\n            <br />\r\n\r\n            <label class=\"detailLabels\">\r\n                ");
            EndContext();
            BeginContext(1548, 46, false);
#line 45 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Post\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.PostStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1594, 60, true);
            WriteLiteral(":\r\n            </label>\r\n            <label id=\"textLabels\">");
            EndContext();
            BeginContext(1655, 64, false);
#line 47 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Post\Delete.cshtml"
                              Write(Html.DisplayFor(model => model.PostStatus.PostStatusDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1719, 90, true);
            WriteLiteral("</label>\r\n            <br />\r\n\r\n            <label class=\"detailLabels\">\r\n                ");
            EndContext();
            BeginContext(1810, 43, false);
#line 51 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Post\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Vehicle));

#line default
#line hidden
            EndContext();
            BeginContext(1853, 60, true);
            WriteLiteral(":\r\n            </label>\r\n            <label id=\"textLabels\">");
            EndContext();
            BeginContext(1914, 44, false);
#line 53 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Post\Delete.cshtml"
                              Write(Html.DisplayFor(model => model.Vehicle.Make));

#line default
#line hidden
            EndContext();
            BeginContext(1958, 54, true);
            WriteLiteral("</label>\r\n            <br />\r\n        </div>\r\n        ");
            EndContext();
            BeginContext(2012, 238, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2684e54cdbe4ae1bd89224270f20767", async() => {
                BeginContext(2038, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2052, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9887e77da30c411db13a3d02bbf5f733", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 57 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Post\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PostId);

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
                BeginContext(2092, 84, true);
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Delete\" id=\"btnAllShared\" />\r\n            ");
                EndContext();
                BeginContext(2176, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ff41975854c47728e8c1ea9414815bc", async() => {
                    BeginContext(2216, 13, true);
                    WriteLiteral("Back to Posts");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2233, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2250, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConestogaCarpool.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591