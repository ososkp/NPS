#pragma checksum "/Users/uakti/Documents/Programs/NPS/ParksService/ParksService/Views/Home/_ViewDetailsModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d260b03ac0f0990723e2c38f496d5d9b10238567"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ViewDetailsModal), @"mvc.1.0.view", @"/Views/Home/_ViewDetailsModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_ViewDetailsModal.cshtml", typeof(AspNetCore.Views_Home__ViewDetailsModal))]
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
#line 1 "/Users/uakti/Documents/Programs/NPS/ParksService/ParksService/Views/_ViewImports.cshtml"
using ParksService;

#line default
#line hidden
#line 1 "/Users/uakti/Documents/Programs/NPS/ParksService/ParksService/Views/Home/_ViewDetailsModal.cshtml"
using ParksService.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d260b03ac0f0990723e2c38f496d5d9b10238567", @"/Views/Home/_ViewDetailsModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d5a6189c9a38b95f2c08188ed2c66da3c77d1c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__ViewDetailsModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ParkViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ViewDetailsModalStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("details-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 97, true);
            WriteLiteral("\r\n    <link href=\"https://fonts.googleapis.com/css?family=Bitter:400,700\" rel=\"stylesheet\">\r\n    ");
            EndContext();
            BeginContext(151, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ee6aeb8249fc48dd9bb381b06bd8331d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(198, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(204, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "11ee9273f1ab4847b60133dc1156e45a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(268, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(272, 1320, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc2379430d9348beaab7dd31e4747dd3", async() => {
                BeginContext(278, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(280, 1303, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9c79ad3e31f4088aeb9629ddb11c0f0", async() => {
                    BeginContext(304, 124, true);
                    WriteLiteral("\r\n    <div id=\"view-details\">\r\n        <div id=\"details-header\">\r\n            <div id=\"details-title\">\r\n                <h3>");
                    EndContext();
                    BeginContext(429, 14, false);
#line 13 "/Users/uakti/Documents/Programs/NPS/ParksService/ParksService/Views/Home/_ViewDetailsModal.cshtml"
               Write(Model.FullName);

#line default
#line hidden
                    EndContext();
                    BeginContext(443, 43, true);
                    WriteLiteral("</h3>\r\n            </div>\r\n            <h5>");
                    EndContext();
                    BeginContext(487, 15, false);
#line 15 "/Users/uakti/Documents/Programs/NPS/ParksService/ParksService/Views/Home/_ViewDetailsModal.cshtml"
           Write(Model.FullState);

#line default
#line hidden
                    EndContext();
                    BeginContext(502, 109, true);
                    WriteLiteral("</h5>\r\n        </div>\r\n        <br />\r\n\r\n        <div class=\"description\">\r\n            <p>\r\n                ");
                    EndContext();
                    BeginContext(612, 17, false);
#line 21 "/Users/uakti/Documents/Programs/NPS/ParksService/ParksService/Views/Home/_ViewDetailsModal.cshtml"
           Write(Model.Description);

#line default
#line hidden
                    EndContext();
                    BeginContext(629, 197, true);
                    WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <hr />\r\n        <button type=\"button\" class=\"collapsible\">Getting There</button>\r\n        <div id=\"directions-collapse\" class=\"content\">\r\n            <p>");
                    EndContext();
                    BeginContext(827, 20, false);
#line 27 "/Users/uakti/Documents/Programs/NPS/ParksService/ParksService/Views/Home/_ViewDetailsModal.cshtml"
          Write(Model.DirectionsInfo);

#line default
#line hidden
                    EndContext();
                    BeginContext(847, 112, true);
                    WriteLiteral("</p>\r\n            <br />\r\n            <div class=\"address\">\r\n                <h4>Address:</h4>\r\n                ");
                    EndContext();
                    BeginContext(960, 19, false);
#line 31 "/Users/uakti/Documents/Programs/NPS/ParksService/ParksService/Views/Home/_ViewDetailsModal.cshtml"
           Write(Model.Address.Line1);

#line default
#line hidden
                    EndContext();
                    BeginContext(979, 29, true);
                    WriteLiteral(" <br />\r\n                <div");
                    EndContext();
                    BeginWriteAttribute("class", " class=\'", 1008, "\'", 1081, 7);
#line 32 "/Users/uakti/Documents/Programs/NPS/ParksService/ParksService/Views/Home/_ViewDetailsModal.cshtml"
WriteAttributeValue("", 1016, Model.Address.Line2.Length, 1016, 27, false);

#line default
#line hidden
                    WriteAttributeValue(" ", 1043, ">", 1044, 2, true);
                    WriteAttributeValue(" ", 1045, "0", 1046, 2, true);
                    WriteAttributeValue(" ", 1047, "?", 1048, 2, true);
                    WriteAttributeValue(" ", 1049, "\"visible-item\"", 1050, 15, true);
                    WriteAttributeValue(" ", 1064, ":", 1065, 2, true);
                    WriteAttributeValue(" ", 1066, "\"hidden-item\")", 1067, 15, true);
                    EndWriteAttribute();
                    BeginContext(1082, 1, true);
                    WriteLiteral(">");
                    EndContext();
                    BeginContext(1084, 19, false);
#line 32 "/Users/uakti/Documents/Programs/NPS/ParksService/ParksService/Views/Home/_ViewDetailsModal.cshtml"
                                                                                          Write(Model.Address.Line2);

#line default
#line hidden
                    EndContext();
                    BeginContext(1103, 28, true);
                    WriteLiteral("</div>\r\n                <div");
                    EndContext();
                    BeginWriteAttribute("class", " class=\'", 1131, "\'", 1204, 7);
#line 33 "/Users/uakti/Documents/Programs/NPS/ParksService/ParksService/Views/Home/_ViewDetailsModal.cshtml"
WriteAttributeValue("", 1139, Model.Address.Line3.Length, 1139, 27, false);

#line default
#line hidden
                    WriteAttributeValue(" ", 1166, ">", 1167, 2, true);
                    WriteAttributeValue(" ", 1168, "0", 1169, 2, true);
                    WriteAttributeValue(" ", 1170, "?", 1171, 2, true);
                    WriteAttributeValue(" ", 1172, "\"visible-item\"", 1173, 15, true);
                    WriteAttributeValue(" ", 1187, ":", 1188, 2, true);
                    WriteAttributeValue(" ", 1189, "\"hidden-item\")", 1190, 15, true);
                    EndWriteAttribute();
                    BeginContext(1205, 1, true);
                    WriteLiteral(">");
                    EndContext();
                    BeginContext(1207, 19, false);
#line 33 "/Users/uakti/Documents/Programs/NPS/ParksService/ParksService/Views/Home/_ViewDetailsModal.cshtml"
                                                                                          Write(Model.Address.Line3);

#line default
#line hidden
                    EndContext();
                    BeginContext(1226, 24, true);
                    WriteLiteral("</div>\r\n                ");
                    EndContext();
                    BeginContext(1251, 18, false);
#line 34 "/Users/uakti/Documents/Programs/NPS/ParksService/ParksService/Views/Home/_ViewDetailsModal.cshtml"
           Write(Model.Address.City);

#line default
#line hidden
                    EndContext();
                    BeginContext(1269, 2, true);
                    WriteLiteral(", ");
                    EndContext();
                    BeginContext(1272, 23, false);
#line 34 "/Users/uakti/Documents/Programs/NPS/ParksService/ParksService/Views/Home/_ViewDetailsModal.cshtml"
                                Write(Model.Address.StateCode);

#line default
#line hidden
                    EndContext();
                    BeginContext(1295, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(1297, 24, false);
#line 34 "/Users/uakti/Documents/Programs/NPS/ParksService/ParksService/Views/Home/_ViewDetailsModal.cshtml"
                                                         Write(Model.Address.PostalCode);

#line default
#line hidden
                    EndContext();
                    BeginContext(1321, 203, true);
                    WriteLiteral(" <br /><br />\r\n            </div>\r\n        </div>\r\n        <hr />\r\n        <button type=\"button\" class=\"collapsible\">Weather</button>\r\n        <div id=\"weather-collapse\" class=\"content\">\r\n            <p>");
                    EndContext();
                    BeginContext(1525, 17, false);
#line 40 "/Users/uakti/Documents/Programs/NPS/ParksService/ParksService/Views/Home/_ViewDetailsModal.cshtml"
          Write(Model.WeatherInfo);

#line default
#line hidden
                    EndContext();
                    BeginContext(1542, 34, true);
                    WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1583, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(1592, 639, true);
            WriteLiteral(@"
    <script type=""text/javascript"">
        var coll = document.getElementsByClassName(""collapsible"");

        for (var i = 0; i < coll.length; i++) {
            coll[i].addEventListener(""click"",
                function () {
                    this.classList.toggle(""active"");
                    var content = this.nextElementSibling;
                    if (content.style.maxHeight) {
                        content.style.maxHeight = null;
                    } else {
                        content.style.maxHeight = content.scrollHeight + ""px"";
                    }
                });
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ParkViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
