#pragma checksum "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cec899253c546781193b57d2193b98f0c62bd1cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flight_GetAllFlights), @"mvc.1.0.view", @"/Views/Flight/GetAllFlights.cshtml")]
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
#nullable restore
#line 1 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\_ViewImports.cshtml"
using WebAppAPIClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\_ViewImports.cshtml"
using WebAppAPIClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cec899253c546781193b57d2193b98f0c62bd1cb", @"/Views/Flight/GetAllFlights.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6056741d84408ddf0b9867597d678b694b984a3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Flight_GetAllFlights : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebAppAPIClient.Models.FlightModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
  
    ViewData["Title"] = "GetAllFlights";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All flights</h1>\r\n\r\n<table class=\"table\">\r\n    <caption style=\"text-align:center\">\r\n");
#nullable restore
#line 11 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"submit\" value=\"Show all\" />\r\n");
#nullable restore
#line 14 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </caption>\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n");
#nullable restore
#line 19 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
                 using (Html.BeginForm())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>\r\n                        Find by departure:\r\n                    </p>\r\n");
#nullable restore
#line 24 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
               Write(Html.TextBox("SDeparture"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"submit\" value=\"Search\" />\r\n");
#nullable restore
#line 26 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </th>\r\n            <th>\r\n");
#nullable restore
#line 30 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
                 using (Html.BeginForm())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>\r\n                        Find by destination:\r\n                    </p>\r\n");
#nullable restore
#line 35 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
               Write(Html.TextBox("SDestination"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"submit\" value=\"Search\" />\r\n");
#nullable restore
#line 37 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </th>\r\n            <th>\r\n");
#nullable restore
#line 41 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
                 using (Html.BeginForm())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>\r\n                        Find by date (XX.XX.XXXX):\r\n                    </p>\r\n");
#nullable restore
#line 46 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
               Write(Html.TextBox("SDate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"submit\" value=\"Search\" />\r\n");
#nullable restore
#line 48 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </th>\r\n        </tr>\r\n    </thead>\r\n</table>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 60 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.FlightNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 63 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.Departure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 66 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n");
            WriteLiteral("                ");
#nullable restore
#line 70 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
           Write(Html.ActionLink("Date", "GetAllFlights", new { sortOrder = ViewBag.DateSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 73 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n");
            WriteLiteral("                ");
#nullable restore
#line 77 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
           Write(Html.ActionLink("Price", "GetAllFlights", new { sortOrder = ViewBag.PriceSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 80 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.SeatsBooked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 86 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 90 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
               Write(Html.DisplayFor(modelItem => item.FlightNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 93 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
               Write(Html.DisplayFor(modelItem => item.Departure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 96 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
               Write(Html.DisplayFor(modelItem => item.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 99 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 102 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
               Write(Html.DisplayFor(modelItem => item.TotalSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 105 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
               Write(Html.DisplayFor(modelItem => item.BasePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 108 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
               Write(Html.DisplayFor(modelItem => item.SeatsBooked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 111 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
               Write(Html.ActionLink("Book", "Details", new { id = item.FlightNo }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 114 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebAppAPIClient.Models.FlightModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
