#pragma checksum "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abe7bee7e92cb16fe318e0f8a234c8a8fe9b28b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Travel_Details), @"mvc.1.0.view", @"/Views/Travel/Details.cshtml")]
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
#line 1 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\_ViewImports.cshtml"
using BesikduzuSeyahat.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\_ViewImports.cshtml"
using BesikduzuSeyahat.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\_ViewImports.cshtml"
using BesikduzuSeyahat.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abe7bee7e92cb16fe318e0f8a234c8a8fe9b28b5", @"/Views/Travel/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9f96bb1bc788ebae835b2a612fa93709aad45e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Travel_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BesikduzuSeyahat.Entity.Direction>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "seatno", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-select mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("required", new global::Microsoft.AspNetCore.Html.HtmlString("required"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/travel/details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
  
    var Price = Model.Price;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
  
    var price = @Price;
    var price1 = @Price - 20;
    var price2 = @Price - 40;
    var price3 = @Price - 60;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card mb-3 shadow\">\r\n\r\n    <div class=\"card-title pl-3 pt-3\">\r\n        <h1>");
#nullable restore
#line 16 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
       Write(TempData["departure"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 16 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                                Write(TempData["arrival"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abe7bee7e92cb16fe318e0f8a234c8a8fe9b28b57429", async() => {
                WriteLiteral("\r\n            <div class=\"row no-gutters\">\r\n\r\n                <div class=\"col-md-8\">\r\n                    <h4>");
#nullable restore
#line 23 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                   Write(Model.Start);

#line default
#line hidden
#nullable disable
                WriteLiteral(" > ");
#nullable restore
#line 23 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                                  Write(Model.Finish);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Aracı</h4>\r\n                    <p><b>Güzergah: </b> ");
#nullable restore
#line 24 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                                    Write(Model.Start);

#line default
#line hidden
#nullable disable
                WriteLiteral(" > ");
#nullable restore
#line 24 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                                                   Write(Model.direction1);

#line default
#line hidden
#nullable disable
                WriteLiteral(" > ");
#nullable restore
#line 24 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                                                                       Write(Model.direction2);

#line default
#line hidden
#nullable disable
                WriteLiteral(" > ");
#nullable restore
#line 24 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                                                                                           Write(Model.direction3);

#line default
#line hidden
#nullable disable
                WriteLiteral(" > ");
#nullable restore
#line 24 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                                                                                                               Write(Model.Finish);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 25 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                  Write(Model.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("  -  ");
#nullable restore
#line 25 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                                  Write(Model.Time);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <br />\r\n                    <p>Dolu koltuk sayısı: ");
#nullable restore
#line 27 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                                      Write(ViewBag.Number);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n\r\n\r\n                    <input type=\"hidden\" name=\"directionId\"");
                BeginWriteAttribute("value", " value=\"", 963, "\"", 989, 1);
#nullable restore
#line 31 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
WriteAttributeValue("", 971, Model.DirectionId, 971, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n\r\n\r\n");
#nullable restore
#line 35 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                     if ((@TempData["departure"].ToString() == @Model.Start) && (@TempData["arrival"].ToString() == @Model.Finish))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p style=\"text-align: right; font-size:26px;\">");
#nullable restore
#line 37 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                                                                 Write(Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₺</p>\r\n                        <input type=\"hidden\" name=\"price\"");
                BeginWriteAttribute("value", " value=\"", 1298, "\"", 1312, 1);
#nullable restore
#line 38 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
WriteAttributeValue("", 1306, Price, 1306, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 39 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                     if ((@TempData["departure"].ToString() == @Model.Start) && (@TempData["arrival"].ToString() == @Model.direction3))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p style=\"text-align: right; font-size:26px;\">");
#nullable restore
#line 42 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                                                                 Write(price1);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₺</p>\r\n                        <input type=\"hidden\" name=\"price\"");
                BeginWriteAttribute("value", " value=\"", 1643, "\"", 1658, 1);
#nullable restore
#line 43 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
WriteAttributeValue("", 1651, price1, 1651, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 44 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                     if ((@TempData["departure"].ToString() == @Model.Start) && (@TempData["arrival"].ToString() == @Model.direction2))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p style=\"text-align: right; font-size:26px;\">");
#nullable restore
#line 47 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                                                                 Write(price2);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₺</p>\r\n                        <input type=\"hidden\" name=\"price\"");
                BeginWriteAttribute("value", " value=\"", 1989, "\"", 2004, 1);
#nullable restore
#line 48 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
WriteAttributeValue("", 1997, price2, 1997, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 49 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                     if ((@TempData["departure"].ToString() == @Model.Start) && (@TempData["arrival"].ToString() == @Model.direction1))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p style=\"text-align: right; font-size:26px;\">");
#nullable restore
#line 52 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                                                                 Write(price3);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₺</p>\r\n                        <input type=\"hidden\" name=\"price\"");
                BeginWriteAttribute("value", " value=\"", 2335, "\"", 2350, 1);
#nullable restore
#line 53 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
WriteAttributeValue("", 2343, price3, 2343, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 54 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                     if ((@TempData["departure"].ToString() == @Model.direction1) && (@TempData["arrival"].ToString() == @Model.Finish))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p style=\"text-align: right; font-size:26px;\">");
#nullable restore
#line 57 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                                                                 Write(price1);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₺</p>\r\n                        <input type=\"hidden\" name=\"price\"");
                BeginWriteAttribute("value", " value=\"", 2682, "\"", 2697, 1);
#nullable restore
#line 58 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
WriteAttributeValue("", 2690, price1, 2690, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 59 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                     if ((@TempData["departure"].ToString() == @Model.direction1) && (@TempData["arrival"].ToString() == @Model.direction3))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p style=\"text-align: right; font-size:26px;\">");
#nullable restore
#line 62 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                                                                 Write(price2);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₺</p>\r\n                        <input type=\"hidden\" name=\"price\"");
                BeginWriteAttribute("value", " value=\"", 3033, "\"", 3048, 1);
#nullable restore
#line 63 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
WriteAttributeValue("", 3041, price2, 3041, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 64 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                     if ((@TempData["departure"].ToString() == @Model.direction1) && (@TempData["arrival"].ToString() == @Model.direction2))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p style=\"text-align: right; font-size:26px;\">");
#nullable restore
#line 67 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                                                                 Write(price3);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₺</p>\r\n                        <input type=\"hidden\" name=\"price\"");
                BeginWriteAttribute("value", " value=\"", 3384, "\"", 3399, 1);
#nullable restore
#line 68 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
WriteAttributeValue("", 3392, price3, 3392, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 69 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                     if ((@TempData["departure"].ToString() == @Model.direction2) && (@TempData["arrival"].ToString() == @Model.direction3))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p style=\"text-align: right; font-size:26px;\">");
#nullable restore
#line 72 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                                                                 Write(price3);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₺</p>\r\n                        <input type=\"hidden\" name=\"price\"");
                BeginWriteAttribute("value", " value=\"", 3735, "\"", 3750, 1);
#nullable restore
#line 73 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
WriteAttributeValue("", 3743, price2, 3743, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 74 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                     if ((@TempData["departure"].ToString() == @Model.direction2) && (@TempData["arrival"].ToString() == @Model.Finish))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p style=\"text-align: right; font-size:26px;\">");
#nullable restore
#line 77 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                                                                 Write(price2);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₺</p>\r\n                        <input type=\"hidden\" name=\"price\"");
                BeginWriteAttribute("value", " value=\"", 4082, "\"", 4097, 1);
#nullable restore
#line 78 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
WriteAttributeValue("", 4090, price2, 4090, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 79 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                     if ((@TempData["departure"].ToString() == @Model.direction3) && (@TempData["arrival"].ToString() == @Model.Finish))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p style=\"text-align: right; font-size:26px;\">");
#nullable restore
#line 82 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                                                                 Write(price3);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₺</p>\r\n                        <input type=\"hidden\" name=\"price\"");
                BeginWriteAttribute("value", " value=\"", 4429, "\"", 4444, 1);
#nullable restore
#line 83 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
WriteAttributeValue("", 4437, price3, 4437, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 84 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"departure\"");
                BeginWriteAttribute("value", " value=\"", 4532, "\"", 4573, 1);
#nullable restore
#line 86 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
WriteAttributeValue("", 4540, TempData["departure"].ToString(), 4540, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"arrival\"");
                BeginWriteAttribute("value", " value=\"", 4634, "\"", 4673, 1);
#nullable restore
#line 87 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
WriteAttributeValue("", 4642, TempData["arrival"].ToString(), 4642, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                </div>

                <div class=""row no-gutters"">

                    <div class=""col-md-12"">
                        <br /><br /><hr /><br />
                        <div class=""form-group"">
                            <input type=""email"" name=""passengermail"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""E-Mail"" required=""required"">
                        </div>
                        <div class=""form-group"">
                            <input type=""text"" name=""passengertel"" class=""form-control""");
                BeginWriteAttribute("id", " id=\"", 5253, "\"", 5258, 0);
                EndWriteAttribute();
                BeginWriteAttribute("aria-describedby", " aria-describedby=\"", 5259, "\"", 5278, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Telefon Numarası\" required=\"required\">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <input type=\"text\" name=\"passengername\" class=\"form-control\"");
                BeginWriteAttribute("id", " id=\"", 5503, "\"", 5508, 0);
                EndWriteAttribute();
                BeginWriteAttribute("aria-describedby", " aria-describedby=\"", 5509, "\"", 5528, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"İsim\" required=\"required\">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <input type=\"text\" name=\"passengersurname\" class=\"form-control\"");
                BeginWriteAttribute("id", " id=\"", 5744, "\"", 5749, 0);
                EndWriteAttribute();
                BeginWriteAttribute("aria-describedby", " aria-describedby=\"", 5750, "\"", 5769, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Soyisim\" required=\"required\">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abe7bee7e92cb16fe318e0f8a234c8a8fe9b28b530973", async() => {
                    WriteLiteral("\r\n                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abe7bee7e92cb16fe318e0f8a234c8a8fe9b28b531274", async() => {
                        WriteLiteral("Koltuk Seçiniz");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 107 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Seats;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                    </div>
                    <button type=""submit"" class=""btn btn-danger btn-lg"" style=""color: white;"">Bilet Al</button>
                    <br />
                </div><br />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div><br />\r\n\r\n</div>\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BesikduzuSeyahat.Entity.Direction> Html { get; private set; }
    }
}
#pragma warning restore 1591
