#pragma checksum "C:\Users\kahyaoğlu61\Desktop\Okul_Projeler\Furkan-Kaya\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Succeed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b992003291fca49a94681e2987f843b58710f85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Travel_Succeed), @"mvc.1.0.view", @"/Views/Travel/Succeed.cshtml")]
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
#line 1 "C:\Users\kahyaoğlu61\Desktop\Okul_Projeler\Furkan-Kaya\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\_ViewImports.cshtml"
using BesikduzuSeyahat.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kahyaoğlu61\Desktop\Okul_Projeler\Furkan-Kaya\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\_ViewImports.cshtml"
using BesikduzuSeyahat.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kahyaoğlu61\Desktop\Okul_Projeler\Furkan-Kaya\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\_ViewImports.cshtml"
using BesikduzuSeyahat.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b992003291fca49a94681e2987f843b58710f85", @"/Views/Travel/Succeed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9f96bb1bc788ebae835b2a612fa93709aad45e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Travel_Succeed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DirectionTicket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"row\" style=\"text-align:center;\">\r\n    <div class=\"col-sm-12\">\r\n        <br />\r\n    <i class=\"fas fa-check-circle\" style=\"font-size:36px; color:green;\"></i><br />\r\n    <br /><p> Sayın ");
#nullable restore
#line 7 "C:\Users\kahyaoğlu61\Desktop\Okul_Projeler\Furkan-Kaya\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Succeed.cshtml"
               Write(Model.Ticket.PassengerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\kahyaoğlu61\Desktop\Okul_Projeler\Furkan-Kaya\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Succeed.cshtml"
                                           Write(Model.Ticket.PassengerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 7 "C:\Users\kahyaoğlu61\Desktop\Okul_Projeler\Furkan-Kaya\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Succeed.cshtml"
                                                                           Write(Model.Ticket.Departure);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -> ");
#nullable restore
#line 7 "C:\Users\kahyaoğlu61\Desktop\Okul_Projeler\Furkan-Kaya\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Succeed.cshtml"
                                                                                                      Write(Model.Ticket.Arrival);

#line default
#line hidden
#nullable disable
            WriteLiteral(" için bilet alma işleminiz başarılı bir şekilde gerçekleştirilmiştir, iyi yolculuklar dileriz.</p> <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b992003291fca49a94681e2987f843b58710f855889", async() => {
                WriteLiteral("Ana Sayfa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <br /><hr /><br />
    <h3>Bilet Bilgileriniz</h3><br />
    
    <table class=""table table-sm table-bordered table-info"">
        <thead>
            <tr>
                <th>Bilet No</th>
                <th>Ad - Soyad</th>
                <th>Mail</th>
                <th>Telefon No</th>
                <th>Başlangıç</th>
                <th>Bitiş</th>
                <th>KoltukNo</th>
                <th>Fiyat</th>
                <th>Tarih - Saat</th>
                
                <th style=""width:75px;"">Sefer No</th>

            </tr>
        </thead>
        <tbody>
            <tr>
                <td>");
#nullable restore
#line 31 "C:\Users\kahyaoğlu61\Desktop\Okul_Projeler\Furkan-Kaya\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Succeed.cshtml"
               Write(Model.Ticket.TicketId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\kahyaoğlu61\Desktop\Okul_Projeler\Furkan-Kaya\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Succeed.cshtml"
               Write(Model.Ticket.PassengerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 32 "C:\Users\kahyaoğlu61\Desktop\Okul_Projeler\Furkan-Kaya\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Succeed.cshtml"
                                           Write(Model.Ticket.PassengerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\kahyaoğlu61\Desktop\Okul_Projeler\Furkan-Kaya\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Succeed.cshtml"
               Write(Model.Ticket.PassengerMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\kahyaoğlu61\Desktop\Okul_Projeler\Furkan-Kaya\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Succeed.cshtml"
               Write(Model.Ticket.PassengerTel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\kahyaoğlu61\Desktop\Okul_Projeler\Furkan-Kaya\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Succeed.cshtml"
               Write(Model.Ticket.Departure);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\kahyaoğlu61\Desktop\Okul_Projeler\Furkan-Kaya\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Succeed.cshtml"
               Write(Model.Ticket.Arrival);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\kahyaoğlu61\Desktop\Okul_Projeler\Furkan-Kaya\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Succeed.cshtml"
               Write(Model.Ticket.SeatNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\kahyaoğlu61\Desktop\Okul_Projeler\Furkan-Kaya\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Succeed.cshtml"
               Write(Model.Ticket.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\kahyaoğlu61\Desktop\Okul_Projeler\Furkan-Kaya\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Succeed.cshtml"
               Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 39 "C:\Users\kahyaoğlu61\Desktop\Okul_Projeler\Furkan-Kaya\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Succeed.cshtml"
                             Write(Model.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                \r\n                <td>");
#nullable restore
#line 41 "C:\Users\kahyaoğlu61\Desktop\Okul_Projeler\Furkan-Kaya\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Travel\Succeed.cshtml"
               Write(Model.Ticket.DirectionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n    <br />\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DirectionTicket> Html { get; private set; }
    }
}
#pragma warning restore 1591
