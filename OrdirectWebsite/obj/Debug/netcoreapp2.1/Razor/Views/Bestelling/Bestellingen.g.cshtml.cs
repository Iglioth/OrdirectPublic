#pragma checksum "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Bestellingen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46ad543981e58f13f5bdb90853c92a87e02264c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bestelling_Bestellingen), @"mvc.1.0.view", @"/Views/Bestelling/Bestellingen.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bestelling/Bestellingen.cshtml", typeof(AspNetCore.Views_Bestelling_Bestellingen))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46ad543981e58f13f5bdb90853c92a87e02264c9", @"/Views/Bestelling/Bestellingen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"267fc0b40c874a0d594b304e68fef71e034ad304", @"/Views/_ViewImports.cshtml")]
    public class Views_Bestelling_Bestellingen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrdirectWebsite.BestellingViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Bestellingen.cshtml"
  
    ViewData["Title"] = "Bestellingen";

#line default
#line hidden
            BeginContext(94, 35, true);
            WriteLiteral("\r\n<h2>Bestellingen van Reservering ");
            EndContext();
            BeginContext(130, 78, false);
#line 7 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Bestellingen.cshtml"
                            Write(Html.DisplayName(Model.bestellingDetailViewModels[0].ReserveringID.ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(208, 18, true);
            WriteLiteral("</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(226, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0aed78d0f4545239e0aad606129551f", async() => {
                BeginContext(249, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(263, 340, true);
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Naam
            </th>
            <th>
                Aantal
            </th>
            <th>
                Ronde
            </th>
            <th>
                Actie
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 30 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Bestellingen.cshtml"
 foreach (BestellingDetailViewModel item in Model.bestellingDetailViewModels) {

#line default
#line hidden
            BeginContext(684, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(733, 27, false);
#line 33 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Bestellingen.cshtml"
           Write(Html.DisplayName(item.Naam));

#line default
#line hidden
            EndContext();
            BeginContext(760, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(816, 40, false);
#line 36 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Bestellingen.cshtml"
           Write(Html.DisplayName(item.Aantal.ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(856, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(912, 39, false);
#line 39 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Bestellingen.cshtml"
           Write(Html.DisplayName(item.Ronde.ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(951, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1007, 45, false);
#line 42 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Bestellingen.cshtml"
           Write(Html.ActionLink("Afronden", "Afronden", item));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 38, true);
            WriteLiteral(" |\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectPublic\OrdirectWebsite\Views\Bestelling\Bestellingen.cshtml"
}

#line default
#line hidden
            BeginContext(1093, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrdirectWebsite.BestellingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
