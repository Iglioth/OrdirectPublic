#pragma checksum "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\IndexVoorRestaurant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f7d45f1bbe4a8320018303d3204f5f1691b2afb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservering_IndexVoorRestaurant), @"mvc.1.0.view", @"/Views/Reservering/IndexVoorRestaurant.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reservering/IndexVoorRestaurant.cshtml", typeof(AspNetCore.Views_Reservering_IndexVoorRestaurant))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f7d45f1bbe4a8320018303d3204f5f1691b2afb", @"/Views/Reservering/IndexVoorRestaurant.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"267fc0b40c874a0d594b304e68fef71e034ad304", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservering_IndexVoorRestaurant : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrdirectWebsite.ReserveringViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\IndexVoorRestaurant.cshtml"
  
    ViewData["Title"] = "IndexVoorRestaurant";

#line default
#line hidden
            BeginContext(102, 162, true);
            WriteLiteral("\r\n<h2>IndexVoorRestaurant</h2>\r\n\r\n<p>\r\n\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 19 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\IndexVoorRestaurant.cshtml"
         foreach (ReserveringDetailViewModel item in Model.reserveringDetailViewModels)
        {

#line default
#line hidden
            BeginContext(364, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(425, 90, false);
#line 23 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\IndexVoorRestaurant.cshtml"
               Write(Html.DisplayName(item.KlantVoorNaam + " " + item.KlantAchterNaam + " om " + item.datetime));

#line default
#line hidden
            EndContext();
            BeginContext(515, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 26 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\IndexVoorRestaurant.cshtml"
                     if (item.Status == "Pending")
                    {
                        

#line default
#line hidden
            BeginContext(662, 47, false);
#line 28 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\IndexVoorRestaurant.cshtml"
                   Write(Html.ActionLink("Accepteer", "Accepteer", item));

#line default
#line hidden
            EndContext();
            BeginContext(736, 41, false);
#line 29 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\IndexVoorRestaurant.cshtml"
                   Write(Html.ActionLink("Weiger", "Delete", item));

#line default
#line hidden
            EndContext();
#line 29 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\IndexVoorRestaurant.cshtml"
                                                                  
                    }

#line default
#line hidden
            BeginContext(802, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\IndexVoorRestaurant.cshtml"
                     if (item.Status == "Geaccepteerd")
                    {
                        

#line default
#line hidden
            BeginContext(909, 37, false);
#line 34 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\IndexVoorRestaurant.cshtml"
                   Write(Html.ActionLink("Open", "Open", item));

#line default
#line hidden
            EndContext();
#line 34 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\IndexVoorRestaurant.cshtml"
                                                              
                    }

#line default
#line hidden
            BeginContext(971, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 36 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\IndexVoorRestaurant.cshtml"
                     if (item.Status == "Open")
                    {
                        

#line default
#line hidden
            BeginContext(1068, 39, false);
#line 38 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\IndexVoorRestaurant.cshtml"
                   Write(Html.ActionLink("Sluit", "Sluit", item));

#line default
#line hidden
            EndContext();
#line 38 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\IndexVoorRestaurant.cshtml"
                                                                
                    }

#line default
#line hidden
            BeginContext(1132, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 40 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\IndexVoorRestaurant.cshtml"
                     if (item.Status == "Gesloten")
                    {
                        

#line default
#line hidden
            BeginContext(1233, 37, false);
#line 42 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\IndexVoorRestaurant.cshtml"
                   Write(Html.ActionLink("Open", "Open", item));

#line default
#line hidden
            EndContext();
#line 42 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\IndexVoorRestaurant.cshtml"
                                                              
                    }

#line default
#line hidden
            BeginContext(1295, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 44 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\IndexVoorRestaurant.cshtml"
                     if (item.Status == "Open" || item.Status == "Gesloten")
                    {
                        

#line default
#line hidden
            BeginContext(1421, 37, false);
#line 46 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\IndexVoorRestaurant.cshtml"
                   Write(Html.ActionLink("Eind", "Eind", item));

#line default
#line hidden
            EndContext();
#line 46 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\IndexVoorRestaurant.cshtml"
                                                              
                    }

#line default
#line hidden
            BeginContext(1483, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 50 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\IndexVoorRestaurant.cshtml"
        }

#line default
#line hidden
            BeginContext(1536, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrdirectWebsite.ReserveringViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
