#pragma checksum "/Users/elliotmckinley/Desktop/ilcwdmapper/Views/iLcwdMapper/AdminPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71fd315937c9dc278aaecf2b3d3951622b7591b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_iLcwdMapper_AdminPage), @"mvc.1.0.view", @"/Views/iLcwdMapper/AdminPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/iLcwdMapper/AdminPage.cshtml", typeof(AspNetCore.Views_iLcwdMapper_AdminPage))]
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
#line 1 "/Users/elliotmckinley/Desktop/ilcwdmapper/Views/_ViewImports.cshtml"
using iLcwdMapper;

#line default
#line hidden
#line 2 "/Users/elliotmckinley/Desktop/ilcwdmapper/Views/_ViewImports.cshtml"
using iLcwdMapper.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71fd315937c9dc278aaecf2b3d3951622b7591b5", @"/Views/iLcwdMapper/AdminPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d0d12b074b5f3f8220c677dc9c8ea1f0b6a1fc8", @"/Views/_ViewImports.cshtml")]
    public class Views_iLcwdMapper_AdminPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Processor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "iLcwdMapper", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "new", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "destroy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 33, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(56, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71fd315937c9dc278aaecf2b3d3951622b7591b55337", async() => {
                BeginContext(62, 131, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <title>Document</title>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(200, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(201, 1481, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71fd315937c9dc278aaecf2b3d3951622b7591b56635", async() => {
                BeginContext(207, 25, true);
                WriteLiteral("\n    <h1>ADMIN PAGE</h1>\n");
                EndContext();
                BeginContext(232, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71fd315937c9dc278aaecf2b3d3951622b7591b57035", async() => {
                    BeginContext(312, 4, true);
                    WriteLiteral("HOME");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
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
                BeginContext(320, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(321, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71fd315937c9dc278aaecf2b3d3951622b7591b58764", async() => {
                    BeginContext(394, 13, true);
                    WriteLiteral("Add Processor");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
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
                BeginContext(411, 456, true);
                WriteLiteral(@"
<div id=""ProcessorListBack"">
    <div id=""ProcessorList"">
        <table class=""table table-hover table-striped table-dark"">
            <thead>
                <tr>
                <th>Processor</th>
                <th>Address</th>
                <th>City</th>
                <th>County</th>
                <th>Lat/Long</th>
                <th>Info</th>
                <th>Action</th>
                </tr>
            </thead>
            <tbody>
");
                EndContext();
#line 28 "/Users/elliotmckinley/Desktop/ilcwdmapper/Views/iLcwdMapper/AdminPage.cshtml"
                 foreach(var w in @Model)
                {

#line default
#line hidden
                BeginContext(927, 53, true);
                WriteLiteral("                    <tr>\n                        <td>");
                EndContext();
                BeginContext(981, 15, false);
#line 31 "/Users/elliotmckinley/Desktop/ilcwdmapper/Views/iLcwdMapper/AdminPage.cshtml"
                       Write(w.ProcessorName);

#line default
#line hidden
                EndContext();
                BeginContext(996, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(1031, 18, false);
#line 32 "/Users/elliotmckinley/Desktop/ilcwdmapper/Views/iLcwdMapper/AdminPage.cshtml"
                       Write(w.ProcessorAddress);

#line default
#line hidden
                EndContext();
                BeginContext(1049, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(1084, 15, false);
#line 33 "/Users/elliotmckinley/Desktop/ilcwdmapper/Views/iLcwdMapper/AdminPage.cshtml"
                       Write(w.ProcessorCity);

#line default
#line hidden
                EndContext();
                BeginContext(1099, 38, true);
                WriteLiteral(", IL</td>\n                        <td>");
                EndContext();
                BeginContext(1138, 17, false);
#line 34 "/Users/elliotmckinley/Desktop/ilcwdmapper/Views/iLcwdMapper/AdminPage.cshtml"
                       Write(w.ProcessorCounty);

#line default
#line hidden
                EndContext();
                BeginContext(1155, 41, true);
                WriteLiteral(" County</td>\n                        <td>");
                EndContext();
                BeginContext(1197, 5, false);
#line 35 "/Users/elliotmckinley/Desktop/ilcwdmapper/Views/iLcwdMapper/AdminPage.cshtml"
                       Write(w.LAT);

#line default
#line hidden
                EndContext();
                BeginContext(1202, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(1205, 5, false);
#line 35 "/Users/elliotmckinley/Desktop/ilcwdmapper/Views/iLcwdMapper/AdminPage.cshtml"
                               Write(w.LNG);

#line default
#line hidden
                EndContext();
                BeginContext(1210, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(1245, 16, false);
#line 36 "/Users/elliotmckinley/Desktop/ilcwdmapper/Views/iLcwdMapper/AdminPage.cshtml"
                       Write(w.ProcessorHours);

#line default
#line hidden
                EndContext();
                BeginContext(1261, 59, true);
                WriteLiteral("</td>\n                        <td>\n                        ");
                EndContext();
                BeginContext(1320, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71fd315937c9dc278aaecf2b3d3951622b7591b513995", async() => {
                    BeginContext(1412, 6, true);
                    WriteLiteral("DELETE");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ProcessorId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 38 "/Users/elliotmckinley/Desktop/ilcwdmapper/Views/iLcwdMapper/AdminPage.cshtml"
                                                                                        WriteLiteral(w.ProcessorId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProcessorId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ProcessorId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProcessorId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1422, 25, true);
                WriteLiteral("\n                        ");
                EndContext();
                BeginContext(1447, 97, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71fd315937c9dc278aaecf2b3d3951622b7591b516732", async() => {
                    BeginContext(1536, 4, true);
                    WriteLiteral("EDIT");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ProcessorId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 39 "/Users/elliotmckinley/Desktop/ilcwdmapper/Views/iLcwdMapper/AdminPage.cshtml"
                                                                                     WriteLiteral(w.ProcessorId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProcessorId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ProcessorId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProcessorId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1544, 57, true);
                WriteLiteral("\n                        </td>\n                    </tr>\n");
                EndContext();
#line 42 "/Users/elliotmckinley/Desktop/ilcwdmapper/Views/iLcwdMapper/AdminPage.cshtml"
                }

#line default
#line hidden
                BeginContext(1619, 56, true);
                WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1682, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Processor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
