#pragma checksum "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\DriverIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc54284ddb20e2d3ad972179ca80d720c13141e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ride_DriverIndex), @"mvc.1.0.view", @"/Views/Ride/DriverIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ride/DriverIndex.cshtml", typeof(AspNetCore.Views_Ride_DriverIndex))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc54284ddb20e2d3ad972179ca80d720c13141e4", @"/Views/Ride/DriverIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bcb33f09722f6e897bb3047affcb0f70986625b", @"/Views/_ViewImports.cshtml")]
    public class Views_Ride_DriverIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ConestogaCarpool.Models.Ride>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ride", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Complete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\DriverIndex.cshtml"
  
    ViewData["Title"] = "Driver Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(147, 33, true);
            WriteLiteral("<div class=\"tableBody\">\r\n    <h2>");
            EndContext();
            BeginContext(181, 16, false);
#line 8 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\DriverIndex.cshtml"
   Write(ViewBag.Username);

#line default
#line hidden
            EndContext();
            BeginContext(197, 41, true);
            WriteLiteral("\'s Rides</h2>\r\n\r\n    <p class=\"tempData\">");
            EndContext();
            BeginContext(239, 19, false);
#line 10 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\DriverIndex.cshtml"
                   Write(TempData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(258, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 11 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\DriverIndex.cshtml"
     if (TempData["Message"] == null)
    {

#line default
#line hidden
            BeginContext(310, 124, true);
            WriteLiteral("        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(435, 42, false);
#line 17 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\DriverIndex.cshtml"
                   Write(Html.DisplayNameFor(model => model.RideId));

#line default
#line hidden
            EndContext();
            BeginContext(477, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(557, 62, false);
#line 20 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\DriverIndex.cshtml"
                   Write(Html.DisplayNameFor(model => model.Request.Passenger.Username));

#line default
#line hidden
            EndContext();
            BeginContext(619, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(699, 49, false);
#line 23 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\DriverIndex.cshtml"
                   Write(Html.DisplayNameFor(model => model.Post.Location));

#line default
#line hidden
            EndContext();
            BeginContext(748, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(828, 52, false);
#line 26 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\DriverIndex.cshtml"
                   Write(Html.DisplayNameFor(model => model.Post.Destination));

#line default
#line hidden
            EndContext();
            BeginContext(880, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(960, 68, false);
#line 29 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\DriverIndex.cshtml"
                   Write(Html.DisplayNameFor(model => model.RideStatus.RideStatusDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1028, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\DriverIndex.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1219, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1304, 41, false);
#line 39 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\DriverIndex.cshtml"
                       Write(Html.DisplayFor(modelItem => item.RideId));

#line default
#line hidden
            EndContext();
            BeginContext(1345, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1437, 61, false);
#line 42 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\DriverIndex.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Request.Passenger.Username));

#line default
#line hidden
            EndContext();
            BeginContext(1498, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1590, 48, false);
#line 45 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\DriverIndex.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Post.Location));

#line default
#line hidden
            EndContext();
            BeginContext(1638, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1730, 51, false);
#line 48 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\DriverIndex.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Post.Destination));

#line default
#line hidden
            EndContext();
            BeginContext(1781, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1873, 67, false);
#line 51 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\DriverIndex.cshtml"
                       Write(Html.DisplayFor(modelItem => item.RideStatus.RideStatusDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1940, 35, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n");
            EndContext();
#line 54 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\DriverIndex.cshtml"
                         if (item.RideStatusId == 1)
                        {

#line default
#line hidden
            BeginContext(2056, 66, true);
            WriteLiteral("                            <td>\r\n                                ");
            EndContext();
            BeginContext(2122, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16169320763d4e539d31d82a54d780e6", async() => {
                BeginContext(2238, 8, true);
                WriteLiteral("Complete");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-DriverId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\DriverIndex.cshtml"
                                                                                       WriteLiteral(ViewBag.DriverId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["DriverId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-DriverId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["DriverId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\DriverIndex.cshtml"
                                                                                                                           WriteLiteral(item.RideId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["RideId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-RideId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["RideId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2250, 37, true);
            WriteLiteral("\r\n                            </td>\r\n");
            EndContext();
#line 59 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\DriverIndex.cshtml"
                        }

#line default
#line hidden
            BeginContext(2314, 27, true);
            WriteLiteral("                    </tr>\r\n");
            EndContext();
#line 61 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\DriverIndex.cshtml"
                }

#line default
#line hidden
            BeginContext(2360, 40, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            EndContext();
#line 64 "C:\Users\Lisda\Documents\School\Fall 2019\MS Enterprice\GroupFive_Iteration3\ConestogaCarpool\ConestogaCarpool\Views\Ride\DriverIndex.cshtml"
    }

#line default
#line hidden
            BeginContext(2407, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ConestogaCarpool.Models.Ride>> Html { get; private set; }
    }
}
#pragma warning restore 1591