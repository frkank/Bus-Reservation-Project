#pragma checksum "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Direction\DirectionList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58579f655d3829db3b2e1431abac1ac6b4ef70a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Direction_DirectionList), @"mvc.1.0.view", @"/Views/Direction/DirectionList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58579f655d3829db3b2e1431abac1ac6b4ef70a4", @"/Views/Direction/DirectionList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9f96bb1bc788ebae835b2a612fa93709aad45e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Direction_DirectionList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Direction>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/direction/deletedirection"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<table class=""table table-bordered mt-3"">
            <thead>
                <tr>
                <th>Kalkış</th>
                <th>Durak 1</th>
                <th>Durak 2</th>
                <th>Durak 3</th>
                <th>Varış</th>
                <th>Tarih</th>
                <th>Saat</th>
                <th>Fiyat</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 16 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Direction\DirectionList.cshtml"
                 if (Model.Count > 0)
                {
                    foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 21 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Direction\DirectionList.cshtml"
                           Write(item.Start);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 22 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Direction\DirectionList.cshtml"
                           Write(item.direction1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 23 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Direction\DirectionList.cshtml"
                           Write(item.direction2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 24 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Direction\DirectionList.cshtml"
                           Write(item.direction3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 25 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Direction\DirectionList.cshtml"
                           Write(item.Finish);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 26 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Direction\DirectionList.cshtml"
                           Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 27 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Direction\DirectionList.cshtml"
                           Write(item.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 28 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Direction\DirectionList.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58579f655d3829db3b2e1431abac1ac6b4ef70a48498", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"directionId\"");
                BeginWriteAttribute("value", " value=\"", 1235, "\"", 1260, 1);
#nullable restore
#line 31 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Direction\DirectionList.cshtml"
WriteAttributeValue("", 1243, item.DirectionId, 1243, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <button type=\"submit\" class=\"btn btn-danger btn-md mr-2\" style=\"color: white;\">Güzergahı Kaldır</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 36 "C:\Users\kahyaoğlu61\Desktop\Bus-Reservation-Project\BesikduzuSeyahat_BusTicket_Furkan_Kaya\BesikduzuSeyahat.WebUI\Views\Direction\DirectionList.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Direction>> Html { get; private set; }
    }
}
#pragma warning restore 1591
