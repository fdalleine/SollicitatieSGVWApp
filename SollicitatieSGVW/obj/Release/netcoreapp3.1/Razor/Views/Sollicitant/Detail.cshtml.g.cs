#pragma checksum "C:\Users\fdall\Desktop\Eindproject C# developer\SollicitatieSGVWApp\SollicitatieSGVW\Views\Sollicitant\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c627fe35cf1cc3f1be6bc5c136f2226ebd71417b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sollicitant_Detail), @"mvc.1.0.view", @"/Views/Sollicitant/Detail.cshtml")]
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
#line 1 "C:\Users\fdall\Desktop\Eindproject C# developer\SollicitatieSGVWApp\SollicitatieSGVW\Views\_ViewImports.cshtml"
using SollicitatieSGVW;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fdall\Desktop\Eindproject C# developer\SollicitatieSGVWApp\SollicitatieSGVW\Views\_ViewImports.cshtml"
using SollicitatieSGVW.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c627fe35cf1cc3f1be6bc5c136f2226ebd71417b", @"/Views/Sollicitant/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85c9835467e04d25e8c204b8d932b6ab9dd73c89", @"/Views/_ViewImports.cshtml")]
    public class Views_Sollicitant_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SollicitantDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"col-md-12 grid-margin grid-margin-md-0\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <nav aria-label=\"breadcrumb\">\r\n                <ol class=\"breadcrumb\">\r\n                    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c627fe35cf1cc3f1be6bc5c136f2226ebd71417b4093", async() => {
                WriteLiteral("Home");
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
            WriteLiteral("</li>\r\n                    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c627fe35cf1cc3f1be6bc5c136f2226ebd71417b5507", async() => {
                WriteLiteral("Lijst Sollicitanten");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                    <li class=""breadcrumb-item active"" aria-current=""page"">Detail sollicitant</li>
                </ol>
            </nav><br /><br />
                        <div class=""wrap align-items-center ml-5"">
                            <p class=""font-weight-bold text-success"" style=""font-size: 20px"">");
#nullable restore
#line 14 "C:\Users\fdall\Desktop\Eindproject C# developer\SollicitatieSGVWApp\SollicitatieSGVW\Views\Sollicitant\Detail.cshtml"
                                                                                        Write(Model.VolledigeNaam);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            <br /><br />
                            <p class=""font-weight-bold"">Algemene gegevens</p>
                            <hr style=""background-color: crimson"" />
                            <p class=""font-weight-normal"">Sollicitantnummer: ");
#nullable restore
#line 18 "C:\Users\fdall\Desktop\Eindproject C# developer\SollicitatieSGVWApp\SollicitatieSGVW\Views\Sollicitant\Detail.cshtml"
                                                                        Write(Model.SollicitantNr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"font-weight-normal\">Rijksregisternummer: ");
#nullable restore
#line 19 "C:\Users\fdall\Desktop\Eindproject C# developer\SollicitatieSGVWApp\SollicitatieSGVW\Views\Sollicitant\Detail.cshtml"
                                                                          Write(Model.RijksregisterNr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"font-weight-normal\">Geboortedatum: ");
#nullable restore
#line 20 "C:\Users\fdall\Desktop\Eindproject C# developer\SollicitatieSGVWApp\SollicitatieSGVW\Views\Sollicitant\Detail.cshtml"
                                                                    Write(Model.GeboorteDatum.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"font-weight-normal\">Adres: ");
#nullable restore
#line 21 "C:\Users\fdall\Desktop\Eindproject C# developer\SollicitatieSGVWApp\SollicitatieSGVW\Views\Sollicitant\Detail.cshtml"
                                                            Write(Model.Adres);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 21 "C:\Users\fdall\Desktop\Eindproject C# developer\SollicitatieSGVWApp\SollicitatieSGVW\Views\Sollicitant\Detail.cshtml"
                                                                          Write(Model.PostCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\fdall\Desktop\Eindproject C# developer\SollicitatieSGVWApp\SollicitatieSGVW\Views\Sollicitant\Detail.cshtml"
                                                                                          Write(Model.WoonPlaats);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"font-weight-normal\">Email: <a href=\"#\">");
#nullable restore
#line 22 "C:\Users\fdall\Desktop\Eindproject C# developer\SollicitatieSGVWApp\SollicitatieSGVW\Views\Sollicitant\Detail.cshtml"
                                                                        Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                            <p class=\"font-weight-normal\">Telefoon: <a");
            BeginWriteAttribute("href", " href=\"", 1591, "\"", 1619, 2);
            WriteAttributeValue("", 1598, "tel:", 1598, 4, true);
#nullable restore
#line 23 "C:\Users\fdall\Desktop\Eindproject C# developer\SollicitatieSGVWApp\SollicitatieSGVW\Views\Sollicitant\Detail.cshtml"
WriteAttributeValue("", 1602, Model.TelefoonNr, 1602, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "C:\Users\fdall\Desktop\Eindproject C# developer\SollicitatieSGVWApp\SollicitatieSGVW\Views\Sollicitant\Detail.cshtml"
                                                                                               Write(Model.TelefoonNr);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></p>
                            <br /><br />
                            <p class=""font-weight-bold"">Diploma & vakken</p>
                            <hr style=""background-color: crimson"" />
                            <p class=""font-weight-normal"">Diploma: ");
#nullable restore
#line 27 "C:\Users\fdall\Desktop\Eindproject C# developer\SollicitatieSGVWApp\SollicitatieSGVW\Views\Sollicitant\Detail.cshtml"
                                                              Write(Model.Dilpoma);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"font-weight-normal\">Vakken: ");
#nullable restore
#line 28 "C:\Users\fdall\Desktop\Eindproject C# developer\SollicitatieSGVWApp\SollicitatieSGVW\Views\Sollicitant\Detail.cshtml"
                                                             Write(Model.VereisteVakken);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"font-weight-normal\">Vrij vanaf: ");
#nullable restore
#line 29 "C:\Users\fdall\Desktop\Eindproject C# developer\SollicitatieSGVWApp\SollicitatieSGVW\Views\Sollicitant\Detail.cshtml"
                                                                 Write(Model.DatumVrij.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"font-weight-normal\">Motivatie: ");
#nullable restore
#line 30 "C:\Users\fdall\Desktop\Eindproject C# developer\SollicitatieSGVWApp\SollicitatieSGVW\Views\Sollicitant\Detail.cshtml"
                                                                Write(Model.Motivatie);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            <br /><br />
                            <p class=""font-weight-bold"">Tewerkstelling</p>
                            <hr style=""background-color: crimson"" />
                            <p class=""font-weight-normal""><i class=""fas fa-envelope"" style=""margin-right:0.6em; color:cornflowerblue""></i><a");
            BeginWriteAttribute("href", " href=\"", 2552, "\"", 2733, 20);
            WriteAttributeValue("", 2559, "mailto:", 2559, 7, true);
#nullable restore
#line 34 "C:\Users\fdall\Desktop\Eindproject C# developer\SollicitatieSGVWApp\SollicitatieSGVW\Views\Sollicitant\Detail.cshtml"
WriteAttributeValue("", 2566, Model.Email, 2566, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2578, "?subject=Tewerkstelling", 2578, 23, true);
            WriteAttributeValue(" ", 2601, "Scholengemeenschap", 2602, 19, true);
            WriteAttributeValue(" ", 2620, "SGVW&body=In", 2621, 13, true);
            WriteAttributeValue(" ", 2633, "bijlage", 2634, 8, true);
            WriteAttributeValue(" ", 2641, "vind", 2642, 5, true);
            WriteAttributeValue(" ", 2646, "je", 2647, 3, true);
            WriteAttributeValue(" ", 2649, "een", 2650, 4, true);
            WriteAttributeValue(" ", 2653, "voorstel", 2654, 9, true);
            WriteAttributeValue(" ", 2662, "die", 2663, 4, true);
            WriteAttributeValue(" ", 2666, "we", 2667, 3, true);
            WriteAttributeValue(" ", 2669, "jou", 2670, 4, true);
            WriteAttributeValue(" ", 2673, "doen", 2674, 5, true);
            WriteAttributeValue(" ", 2678, "ivm", 2679, 4, true);
            WriteAttributeValue(" ", 2682, "een", 2683, 4, true);
            WriteAttributeValue(" ", 2686, "tewerkstelling", 2687, 15, true);
            WriteAttributeValue(" ", 2701, "binnen", 2702, 7, true);
            WriteAttributeValue(" ", 2708, "onze", 2709, 5, true);
            WriteAttributeValue(" ", 2713, "scholengemeenschap.", 2714, 20, true);
            EndWriteAttribute();
            WriteLiteral(">Mail voorstel tewerkstelling</a></p>\r\n                            <br /><br />\r\n                        </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SollicitantDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
