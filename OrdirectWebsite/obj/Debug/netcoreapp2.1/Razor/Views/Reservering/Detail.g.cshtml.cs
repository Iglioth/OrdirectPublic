#pragma checksum "D:\School\Semester2Take2Individueel\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3330e692526b1c509b57e318c0d4f99d2fa6952c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservering_Detail), @"mvc.1.0.view", @"/Views/Reservering/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reservering/Detail.cshtml", typeof(AspNetCore.Views_Reservering_Detail))]
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
#line 1 "D:\School\Semester2Take2Individueel\OrdirectS2\OrdirectWebsite\Views\_ViewImports.cshtml"
using OrdirectWebsite;

#line default
#line hidden
#line 2 "D:\School\Semester2Take2Individueel\OrdirectS2\OrdirectWebsite\Views\_ViewImports.cshtml"
using OrdirectWebsite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3330e692526b1c509b57e318c0d4f99d2fa6952c", @"/Views/Reservering/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49881a417c454c84dcd39c7f0d5523ca5e0e3c5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservering_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrdirectWebsite.ReserveringDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(50, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\School\Semester2Take2Individueel\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(90, 131, true);
            WriteLiteral("\n<h2>Detail</h2>\n\n<div>\n    <h4>ReserveringDetailViewModel</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(222, 49, false);
#line 14 "D:\School\Semester2Take2Individueel\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.ReserveringID));

#line default
#line hidden
            EndContext();
            BeginContext(271, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(312, 45, false);
#line 17 "D:\School\Semester2Take2Individueel\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
       Write(Html.DisplayFor(model => model.ReserveringID));

#line default
#line hidden
            EndContext();
            BeginContext(357, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(398, 44, false);
#line 20 "D:\School\Semester2Take2Individueel\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.datetime));

#line default
#line hidden
            EndContext();
            BeginContext(442, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(483, 40, false);
#line 23 "D:\School\Semester2Take2Individueel\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
       Write(Html.DisplayFor(model => model.datetime));

#line default
#line hidden
            EndContext();
            BeginContext(523, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(564, 42, false);
#line 26 "D:\School\Semester2Take2Individueel\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(606, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(647, 38, false);
#line 29 "D:\School\Semester2Take2Individueel\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(685, 16, true);
            WriteLiteral("\n        </dd>\n\n");
            EndContext();
#line 32 "D:\School\Semester2Take2Individueel\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
         if (Model.Status == "Open")
        {

#line default
#line hidden
            BeginContext(748, 33, true);
            WriteLiteral("            <dd>\n                ");
            EndContext();
            BeginContext(782, 72, false);
#line 35 "D:\School\Semester2Take2Individueel\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
           Write(Html.ActionLink("Bestel Hier", "Overview", controllerName: "Bestelling"));

#line default
#line hidden
            EndContext();
            BeginContext(854, 19, true);
            WriteLiteral("\n            </dd>\n");
            EndContext();
#line 37 "D:\School\Semester2Take2Individueel\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(906, 218, true);
            WriteLiteral("            <dt>\n                <label> Wacht voor het restaurant om je reservering open te zetten.</label>\n            </dt>\n            <dd>\n                <button disabled> Bestel Hier </button>\n            </dd>\n");
            EndContext();
#line 46 "D:\School\Semester2Take2Individueel\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
        }

#line default
#line hidden
            BeginContext(1134, 28, true);
            WriteLiteral("\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1163, 116, false);
#line 51 "D:\School\Semester2Take2Individueel\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
Write(Html.ActionLink("Annuleren", "Delete", routeValues: new { id = Model.ReserveringID }, controllerName: "Reservering"));

#line default
#line hidden
            EndContext();
            BeginContext(1279, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1286, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf6cca707a0540b89665d6cc3c1d481d", async() => {
                BeginContext(1308, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(1324, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrdirectWebsite.ReserveringDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
