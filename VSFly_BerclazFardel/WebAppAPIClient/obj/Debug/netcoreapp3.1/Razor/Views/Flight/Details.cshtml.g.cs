#pragma checksum "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "374445c32cc740d9cdb159134759b0416ca9d756"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flight_Details), @"mvc.1.0.view", @"/Views/Flight/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"374445c32cc740d9cdb159134759b0416ca9d756", @"/Views/Flight/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6056741d84408ddf0b9867597d678b694b984a3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Flight_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppAPIClient.ViewModel.FlightBooking>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAllFlights", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
  
    ViewData["Title"] = "Details";
    var fillRate = 0;
    string color = "green";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Booking form</h1>\r\n\r\n<h4>Book this flight</h4>\r\n<hr />\r\n<div>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Flight.FlightNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
       Write(Html.DisplayFor(model => model.Flight.FlightNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Flight.Departure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
       Write(Html.DisplayFor(model => model.Flight.Departure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Flight.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
       Write(Html.DisplayFor(model => model.Flight.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Flight.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
       Write(Html.DisplayFor(model => model.Flight.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Flight.TotalSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
       Write(Html.DisplayFor(model => model.Flight.TotalSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Flight.SeatsBooked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
       Write(Html.DisplayFor(model => model.Flight.SeatsBooked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Fill rate\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 55 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
              
                fillRate = (Model.Flight.SeatsBooked * 100) / Model.Flight.TotalSeats;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
             if (fillRate >= 50)
            {
                color = "orange";
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 64 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
             if (fillRate >= 80)
            {
                color = "red";

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <span");
            BeginWriteAttribute("style", " style=\"", 2012, "\"", 2033, 3);
            WriteAttributeValue("", 2020, "color:", 2020, 6, true);
#nullable restore
#line 70 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
WriteAttributeValue("", 2026, color, 2026, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2032, ";", 2032, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
#nullable restore
#line 71 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
           Write(fillRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                %\r\n            </span>\r\n\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            Price\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 81 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
       Write(Html.DisplayFor(model => model.Flight.BasePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(" CHF\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n\r\n<div>\r\n");
#nullable restore
#line 88 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
     using (Html.BeginForm("Details", "Flight", new { flightNo = Model.Flight.FlightNo, basePrice = Model.Flight.BasePrice }, FormMethod.Post))
    {
        //Options

#line default
#line hidden
#nullable disable
            WriteLiteral("        <b>");
#nullable restore
#line 91 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
      Write(Html.Label("Check your options"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n        <br />\r\n");
            WriteLiteral("Popcorn");
#nullable restore
#line 94 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
   Write(Html.CheckBox("popcorn", false, new { style = "width: 50px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("Film");
#nullable restore
#line 97 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
   Write(Html.CheckBox("film", false, new { style = "width: 50px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("Mojito");
#nullable restore
#line 100 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
   Write(Html.CheckBox("mojito", false, new { style = "width: 50px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br /><br />\r\n");
#nullable restore
#line 102 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"

        /* Error message */

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\r\n");
#nullable restore
#line 105 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
             if (@ViewBag.Error == "noAccount")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <i style=\"color:red\">You do not have any account. Please create one or contact administrator.</i>\r\n");
#nullable restore
#line 108 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </p>\r\n");
#nullable restore
#line 110 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"

        //Firstname

#line default
#line hidden
#nullable disable
            WriteLiteral("        <b>");
#nullable restore
#line 112 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
      Write(Html.Label("Enter your firstname"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n        <br />\r\n");
#nullable restore
#line 114 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
   Write(Html.TextBox("firstname", "", new { style = "width: 305px;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
                                                                       

        //Lastname

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br /><br />\r\n        <b>");
#nullable restore
#line 118 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
      Write(Html.Label("Enter your lastname"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n        <br />\r\n");
#nullable restore
#line 120 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
   Write(Html.TextBox("lastname", "", new { style = "width: 305px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br /><br />\r\n");
            WriteLiteral("        <input type=\"submit\" class=\"btn btn-info btn-sm active\" style=\"background-color:green;width:150px;\" value=\"BOOK\" id=\"btnSubmit\" name=\"Submit\" />\r\n");
#nullable restore
#line 124 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div>\r\n    <br /><br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "374445c32cc740d9cdb159134759b0416ca9d75615992", async() => {
                WriteLiteral("Go back to all flights");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 133 "C:\Users\brice\Source\Repos\Bearbrice\BerclazFardel_VSFly\VSFly_BerclazFardel\WebAppAPIClient\Views\Flight\Details.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppAPIClient.ViewModel.FlightBooking> Html { get; private set; }
    }
}
#pragma warning restore 1591
