#pragma checksum "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "037cebcf2b686d95bce305eb78404e58578cf91a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"037cebcf2b686d95bce305eb78404e58578cf91a", @"/Views/Flight/GetAllFlights.cshtml")]
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

    String ButtonCss = "border-radius: 4px;color:white;";
    var fillRate = 0;
    string color = "green";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All flights</h1>\r\n\r\n<table class=\"table\">\r\n    <caption style=\"text-align:center\">\r\n");
#nullable restore
#line 16 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"submit\" value=\"Show all\"");
            BeginWriteAttribute("style", " style=\"", 407, "\"", 454, 2);
#nullable restore
#line 18 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
WriteAttributeValue("", 415, ButtonCss, 415, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 425, "background-color:dodgerblue;", 426, 29, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 19 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </caption>\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n");
#nullable restore
#line 24 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
                 using (Html.BeginForm())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>\r\n                        Find by departure:\r\n                    </p>\r\n");
#nullable restore
#line 29 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
               Write(Html.TextBox("SDeparture"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"submit\" value=\"Search\"");
            BeginWriteAttribute("style", " style=\"", 797, "\"", 845, 2);
#nullable restore
#line 30 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
WriteAttributeValue("", 805, ButtonCss, 805, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 815, "background-color:deepskyblue;", 816, 30, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 31 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </th>\r\n            <th>\r\n");
#nullable restore
#line 35 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
                 using (Html.BeginForm())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>\r\n                        Find by destination:\r\n                    </p>\r\n");
#nullable restore
#line 40 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
               Write(Html.TextBox("SDestination"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"submit\" value=\"Search\"");
            BeginWriteAttribute("style", " style=\"", 1174, "\"", 1222, 2);
#nullable restore
#line 41 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
WriteAttributeValue("", 1182, ButtonCss, 1182, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1192, "background-color:deepskyblue;", 1193, 30, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 42 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </th>\r\n            <th>\r\n");
#nullable restore
#line 46 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
                 using (Html.BeginForm())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>\r\n                        Find by date (00.00.0000):\r\n                    </p>\r\n");
#nullable restore
#line 51 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
               Write(Html.TextBox("SDate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"submit\" value=\"Search\"");
            BeginWriteAttribute("style", " style=\"", 1550, "\"", 1598, 2);
#nullable restore
#line 52 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
WriteAttributeValue("", 1558, ButtonCss, 1558, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1568, "background-color:deepskyblue;", 1569, 30, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 53 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </th>\r\n        </tr>\r\n    </thead>\r\n</table>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 65 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.FlightNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 68 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.Departure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 71 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n");
            WriteLiteral("                ");
#nullable restore
#line 75 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
           Write(Html.ActionLink("Date", "GetAllFlights", new { sortOrder = ViewBag.DateSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 78 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 81 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
           Write(Html.DisplayNameFor(model => model.SeatsBooked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Fill rate\r\n            </th>\r\n            <th>\r\n");
            WriteLiteral("                ");
#nullable restore
#line 88 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
           Write(Html.ActionLink("Price", "GetAllFlights", new { sortOrder = ViewBag.PriceSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 94 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 98 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.FlightNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 101 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.Departure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 104 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 107 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 110 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 113 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.SeatsBooked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n\r\n");
#nullable restore
#line 117 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
                  
                    fillRate = (item.SeatsBooked * 100) / @item.TotalSeats;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 121 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
                 if (fillRate >= 50)
                {
                    color = "orange";
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 126 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
                 if (fillRate >= 80)
                {
                    color = "red";
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 131 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
                 if (fillRate < 50)
                {
                    color = "green";
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span");
            BeginWriteAttribute("style", " style=\"", 3951, "\"", 3972, 3);
            WriteAttributeValue("", 3959, "color:", 3959, 6, true);
#nullable restore
#line 136 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
WriteAttributeValue("", 3965, color, 3965, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3971, ";", 3971, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 137 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
               Write(fillRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    %\r\n                </span>\r\n\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 143 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
           Write(Html.DisplayFor(modelItem => item.BasePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(" CHF\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 147 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
           Write(Html.ActionLink("Book", "Details", new { id = item.FlightNo }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 150 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\GetAllFlights.cshtml"
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
