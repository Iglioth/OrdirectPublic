#pragma checksum "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7498e6945a7a91dfea674b4df1fb54afab76c63f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservering_Index), @"mvc.1.0.view", @"/Views/Reservering/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reservering/Index.cshtml", typeof(AspNetCore.Views_Reservering_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7498e6945a7a91dfea674b4df1fb54afab76c63f", @"/Views/Reservering/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"267fc0b40c874a0d594b304e68fef71e034ad304", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservering_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrdirectWebsite.ReserveringViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(88, 28, true);
            WriteLiteral("\r\n<h2>Reserveringen</h2>\r\n\r\n");
            EndContext();
#line 9 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\Index.cshtml"
 if (Model == null)
{

#line default
#line hidden
            BeginContext(140, 157, true);
            WriteLiteral("    <h3>Geen Reserveringen Gevonden</h3>\r\n    <p> Helaas zijn er geen reserveringen gevonden. Maak een reservering aan om je reserveringen te bekijken!</p>\r\n");
            EndContext();
#line 13 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\Index.cshtml"
}

#line default
#line hidden
#line 14 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\Index.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(324, 143, true);
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 23 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\Index.cshtml"
             foreach (ReserveringDetailViewModel item in Model.reserveringDetailViewModels)
            {

#line default
#line hidden
            BeginContext(575, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(648, 80, false);
#line 27 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\Index.cshtml"
                   Write(Html.DisplayName(item.RestaurantNaam + " om " + Convert.ToString(item.datetime)));

#line default
#line hidden
            EndContext();
            BeginContext(728, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(808, 108, false);
#line 30 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\Index.cshtml"
                   Write(Html.ActionLink(linkText: "Details", actionName: "Detail", controllerName: "Reservering", routeValues: item));

#line default
#line hidden
            EndContext();
            BeginContext(916, 54, true);
            WriteLiteral(" |\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 33 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(985, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 36 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Reservering\Index.cshtml"

}

#line default
#line hidden
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
