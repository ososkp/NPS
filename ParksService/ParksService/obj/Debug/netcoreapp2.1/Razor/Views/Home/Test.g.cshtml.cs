#pragma checksum "C:\Users\ososk\source\repos\ParksService\ParksService\Views\Home\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d92e43f4b1e0092c0f6d129afec579483fb42d8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Test), @"mvc.1.0.view", @"/Views/Home/Test.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Test.cshtml", typeof(AspNetCore.Views_Home_Test))]
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
#line 1 "C:\Users\ososk\source\repos\ParksService\ParksService\Views\_ViewImports.cshtml"
using ParksService;

#line default
#line hidden
#line 1 "C:\Users\ososk\source\repos\ParksService\ParksService\Views\Home\Test.cshtml"
using ParksService.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d92e43f4b1e0092c0f6d129afec579483fb42d8d", @"/Views/Home/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d5a6189c9a38b95f2c08188ed2c66da3c77d1c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Park>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\ososk\source\repos\ParksService\ParksService\Views\Home\Test.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(101, 530, true);
            WriteLiteral(@"
<div class=""container"">
    <button id=""parks-button"" class=""btn btn-primary btn-sm"">Refresh Parks List</button>
    <br />
    <br />
    <div class=""row"">
        <table class=""table table-hover table-bordered"">
            <thead>
                <tr>
                    <td>Id</td>
                    <td>Full Name</td>
                    <td>Desc</td>
                    <td>Latitude/Longitude</td>
                    <td>Designation</td>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 24 "C:\Users\ososk\source\repos\ParksService\ParksService\Views\Home\Test.cshtml"
                 foreach (var park in Model)
                {

#line default
#line hidden
            BeginContext(696, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(751, 7, false);
#line 27 "C:\Users\ososk\source\repos\ParksService\ParksService\Views\Home\Test.cshtml"
                       Write(park.Id);

#line default
#line hidden
            EndContext();
            BeginContext(758, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(794, 13, false);
#line 28 "C:\Users\ososk\source\repos\ParksService\ParksService\Views\Home\Test.cshtml"
                       Write(park.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(807, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(843, 16, false);
#line 29 "C:\Users\ososk\source\repos\ParksService\ParksService\Views\Home\Test.cshtml"
                       Write(park.Description);

#line default
#line hidden
            EndContext();
            BeginContext(859, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(895, 12, false);
#line 30 "C:\Users\ososk\source\repos\ParksService\ParksService\Views\Home\Test.cshtml"
                       Write(park.LatLong);

#line default
#line hidden
            EndContext();
            BeginContext(907, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(943, 16, false);
#line 31 "C:\Users\ososk\source\repos\ParksService\ParksService\Views\Home\Test.cshtml"
                       Write(park.Designation);

#line default
#line hidden
            EndContext();
            BeginContext(959, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 33 "C:\Users\ososk\source\repos\ParksService\ParksService\Views\Home\Test.cshtml"
                }

#line default
#line hidden
            BeginContext(1012, 62, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1092, 1329, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            var refreshParks = function () {
                $(""#parks-button"").text(""Loading..."");
                    $.ajax({
                        url: ""https://developer.nps.gov/api/v1/parks"",
                        data: {
                            api_key: ""5hCAzcru81QKEg1bDSyJz6KlMaFYTa3HTWmACBBs""
                        },
                    type: ""GET"",
                    dataType: ""JSON"",
                        success: function (data) {
                            console.dir(data.data);
                        var parks = JSON.stringify(data.data);
                        $.ajax({
                            type: ""POST"",
                            url: ""/Home/PopulateParks"",
                            data: parks,
                            dataType: ""json"",
                            contentType: ""application/json; charset=utf-8"",
                            complete: function() {
                           ");
                WriteLiteral(@"     $(""#parks-button"").text(""Refresh Parks List"");
                            }
                        });
                    }
                });
            };
            $(""#parks-button"").click(function () {
                refreshParks();
            });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Park>> Html { get; private set; }
    }
}
#pragma warning restore 1591
