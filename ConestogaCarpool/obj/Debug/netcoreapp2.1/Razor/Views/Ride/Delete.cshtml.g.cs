#pragma checksum "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e83888cd3253e3bad5f320675f839d2a7c6aaa6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ride_Delete), @"mvc.1.0.view", @"/Views/Ride/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ride/Delete.cshtml", typeof(AspNetCore.Views_Ride_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e83888cd3253e3bad5f320675f839d2a7c6aaa6", @"/Views/Ride/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bcb33f09722f6e897bb3047affcb0f70986625b", @"/Views/_ViewImports.cshtml")]
    public class Views_Ride_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConestogaCarpool.Models.Ride>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(128, 289, true);
            WriteLiteral(@"<div class=""allBodyLeft"">
    <div class=""transparentBack"">
        <h2>Delete</h2>

        <h3>Are you sure you want to delete this?</h3>
        <div>
            <h4>Ride</h4>
            <hr />
            <dl class=""dl-horizontal"">
                <dt>
                    ");
            EndContext();
            BeginContext(418, 40, false);
#line 17 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Post));

#line default
#line hidden
            EndContext();
            BeginContext(458, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(526, 48, false);
#line 20 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Post.Destination));

#line default
#line hidden
            EndContext();
            BeginContext(574, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(642, 43, false);
#line 23 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Request));

#line default
#line hidden
            EndContext();
            BeginContext(685, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(753, 49, false);
#line 26 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Request.RequestId));

#line default
#line hidden
            EndContext();
            BeginContext(802, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(870, 46, false);
#line 29 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.RideStatus));

#line default
#line hidden
            EndContext();
            BeginContext(916, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(984, 64, false);
#line 32 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\Delete.cshtml"
               Write(Html.DisplayFor(model => model.RideStatus.RideStatusDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1048, 68, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n        ");
            EndContext();
            BeginContext(1116, 167, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b444fcd565de4f3c925ec8fcd5be497e", async() => {
                BeginContext(1142, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1156, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c7569009a2894fd2aa3cfbc41e49452e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 37 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RideId);

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
                BeginContext(1196, 80, true);
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Delete\" id=\"btnAllShared\" />\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1283, 22, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConestogaCarpool.Models.Ride> Html { get; private set; }
    }
}
#pragma warning restore 1591