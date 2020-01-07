#pragma checksum "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Overview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe65d1668a748d25967a4344ad96a9f66f500328"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bestelling_Overview), @"mvc.1.0.view", @"/Views/Bestelling/Overview.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bestelling/Overview.cshtml", typeof(AspNetCore.Views_Bestelling_Overview))]
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
#line 1 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\_ViewImports.cshtml"
using OrdirectWebsite;

#line default
#line hidden
#line 2 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\_ViewImports.cshtml"
using OrdirectWebsite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe65d1668a748d25967a4344ad96a9f66f500328", @"/Views/Bestelling/Overview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"267fc0b40c874a0d594b304e68fef71e034ad304", @"/Views/_ViewImports.cshtml")]
    public class Views_Bestelling_Overview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrdirectWebsite.BestellingViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Overview.cshtml"
  
    ViewData["Title"] = "Overview";

#line default
#line hidden
            BeginContext(88, 578, true);
            WriteLiteral(@"
<h2>Overview</h2>

<div class=""container"">
    <div class=""row"">
        <div class=""col-6"">
            <div class=""table thead-dark"">
                <label>Gerechten</label>
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th class=""col-md-1"">Naam</th>
                            <th class=""col-md-2"">Descriptie</th>
                            <th class=""col-md-3"">Acties</th>
                        </tr>
                    </thead>
                    <tbody>

");
            EndContext();
#line 23 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Overview.cshtml"
                         if (Model.gerechtDetailViewModels[0].Naam != null && Model.gerechtDetailViewModels[0].Descriptie != null)
                        {
                            

#line default
#line hidden
#line 25 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Overview.cshtml"
                             foreach (GerechtDetailViewModel item in Model.gerechtDetailViewModels)
                            {

#line default
#line hidden
            BeginContext(957, 137, true);
            WriteLiteral("                                <tr>\r\n                                    <td class=\"col-md-1\">\r\n                                        ");
            EndContext();
            BeginContext(1095, 27, false);
#line 29 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Overview.cshtml"
                                   Write(Html.DisplayName(item.Naam));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 144, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"col-md-2\">\r\n                                        ");
            EndContext();
            BeginContext(1267, 33, false);
#line 32 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Overview.cshtml"
                                   Write(Html.DisplayName(item.Descriptie));

#line default
#line hidden
            EndContext();
            BeginContext(1300, 144, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"col-md-3\">\r\n                                        ");
            EndContext();
            BeginContext(1445, 124, false);
#line 35 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Overview.cshtml"
                                   Write(Html.ActionLink(controllerName: "Bestelling", actionName: "VoegToeAanHuidigeBestelling", linkText: " + ", routeValues: item));

#line default
#line hidden
            EndContext();
            BeginContext(1569, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 38 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Overview.cshtml"
                            }

#line default
#line hidden
#line 38 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Overview.cshtml"
                             

                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1770, 238, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <text> Dit restaurant heeft nog geen gerechten.</text>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 48 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Overview.cshtml"
                        }

#line default
#line hidden
            BeginContext(2035, 606, true);
            WriteLiteral(@"
                    </tbody>
                </table>
            </div>
        </div>
        <div class=""col-6"">
            <div class=""table thead-dark"">
                <label>Huidige Bestelling</label>
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th class=""col-md-1"">Naam</th>
                            <th class=""col-md-2"">Aantal</th>
                            <th class=""col-md-3"">Acties</th>
                        </tr>
                    </thead>
                    <tbody>

");
            EndContext();
#line 67 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Overview.cshtml"
                         if (Model.HuidigeBestelling != null)
                        {
                            

#line default
#line hidden
#line 69 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Overview.cshtml"
                             foreach (GerechtDetailViewModel item in Model.HuidigeBestelling)
                            {

#line default
#line hidden
            BeginContext(2857, 137, true);
            WriteLiteral("                                <tr>\r\n                                    <td class=\"col-md-1\">\r\n                                        ");
            EndContext();
            BeginContext(2995, 27, false);
#line 73 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Overview.cshtml"
                                   Write(Html.DisplayName(item.Naam));

#line default
#line hidden
            EndContext();
            BeginContext(3022, 144, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"col-md-2\">\r\n                                        ");
            EndContext();
            BeginContext(3167, 40, false);
#line 76 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Overview.cshtml"
                                   Write(Html.DisplayName(item.Aantal.ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(3207, 144, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"col-md-3\">\r\n                                        ");
            EndContext();
            BeginContext(3352, 126, false);
#line 79 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Overview.cshtml"
                                   Write(Html.ActionLink(controllerName: "Bestelling", actionName: "VerwijderVanHuidigeBestelling", linkText: " - ", routeValues: item));

#line default
#line hidden
            EndContext();
            BeginContext(3478, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 82 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Overview.cshtml"
                            }

#line default
#line hidden
#line 82 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Overview.cshtml"
                             

                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3679, 280, true);
            WriteLiteral(@"                            <tr>
                                <td>
                                    <text class=""text-center"">Je hebt nog geen gerechten toegevoegd aan je huidige bestelling</text>
                                </td>
                            </tr>
");
            EndContext();
#line 92 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Overview.cshtml"
                        }

#line default
#line hidden
            BeginContext(3986, 313, true);
            WriteLiteral(@"                    </tbody>
                </table>
                <button>Bestelling Plaatsen</button>
            </div>
        </div>
    </div>
</div>
<br />
<div class=""col-6"">
    <label> Alle Bestellingen</label>
</div>
<div class=""col-6"">
    <label> Bestelling Details</label>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrdirectWebsite.BestellingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
