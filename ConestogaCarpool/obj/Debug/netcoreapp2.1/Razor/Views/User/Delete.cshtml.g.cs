#pragma checksum "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\User\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3ca5aa3356e01d6c92485e569f8f066513f20af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Delete), @"mvc.1.0.view", @"/Views/User/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Delete.cshtml", typeof(AspNetCore.Views_User_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3ca5aa3356e01d6c92485e569f8f066513f20af", @"/Views/User/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bcb33f09722f6e897bb3047affcb0f70986625b", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConestogaCarpool.Models.User>
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
#line 3 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\User\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(128, 256, true);
            WriteLiteral(@"
<div class=""allBodyLeft"">
    <div class=""transparentBack"">
        <h2>Delete Account</h2>

        <h3>Are you sure you want to delete your account?</h3>
        <div>
            <hr />
            <label class=""detailLabels"">
                ");
            EndContext();
            BeginContext(385, 44, false);
#line 16 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\User\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(429, 60, true);
            WriteLiteral(":\r\n            </label>\r\n            <label id=\"textLabels\">");
            EndContext();
            BeginContext(490, 40, false);
#line 18 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\User\Delete.cshtml"
                              Write(Html.DisplayFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(530, 110, true);
            WriteLiteral("</label>\r\n            <br />\r\n            <br />\r\n\r\n            <label class=\"detailLabels\">\r\n                ");
            EndContext();
            BeginContext(641, 45, false);
#line 23 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\User\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(686, 60, true);
            WriteLiteral(":\r\n            </label>\r\n            <label id=\"textLabels\">");
            EndContext();
            BeginContext(747, 41, false);
#line 25 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\User\Delete.cshtml"
                              Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(788, 110, true);
            WriteLiteral("</label>\r\n            <br />\r\n            <br />\r\n\r\n            <label class=\"detailLabels\">\r\n                ");
            EndContext();
            BeginContext(899, 44, false);
#line 30 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\User\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(943, 60, true);
            WriteLiteral(":\r\n            </label>\r\n            <label id=\"textLabels\">");
            EndContext();
            BeginContext(1004, 40, false);
#line 32 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\User\Delete.cshtml"
                              Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1044, 110, true);
            WriteLiteral("</label>\r\n            <br />\r\n            <br />\r\n\r\n            <label class=\"detailLabels\">\r\n                ");
            EndContext();
            BeginContext(1155, 41, false);
#line 37 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\User\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1196, 60, true);
            WriteLiteral(":\r\n            </label>\r\n            <label id=\"textLabels\">");
            EndContext();
            BeginContext(1257, 37, false);
#line 39 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\User\Delete.cshtml"
                              Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1294, 74, true);
            WriteLiteral("</label>\r\n            <br />\r\n            <br />\r\n        </div>\r\n        ");
            EndContext();
            BeginContext(1368, 231, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ea6eb0282a0436097f393313f58c3db", async() => {
                BeginContext(1394, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1408, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dea5c3cb04e945aea3cdf5327023e6ed", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 44 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\User\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserId);

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
                BeginContext(1448, 84, true);
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Delete\" id=\"btnAllShared\" />\r\n            ");
                EndContext();
                BeginContext(1532, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b37c6e4f9bc44ae4ab310cf38a4c0b90", async() => {
                    BeginContext(1572, 6, true);
                    WriteLiteral("Cancel");
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
                BeginContext(1582, 10, true);
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
            BeginContext(1599, 22, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConestogaCarpool.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591