#pragma checksum "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectS2\OrdirectS2\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d570b06d8f32b7631144295075a93a10fb926ba"
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
#line 1 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectS2\OrdirectS2\OrdirectS2\OrdirectWebsite\Views\_ViewImports.cshtml"
using OrdirectWebsite;

#line default
#line hidden
#line 2 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectS2\OrdirectS2\OrdirectS2\OrdirectWebsite\Views\_ViewImports.cshtml"
using OrdirectWebsite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d570b06d8f32b7631144295075a93a10fb926ba", @"/Views/Reservering/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"267fc0b40c874a0d594b304e68fef71e034ad304", @"/Views/_ViewImports.cshtml")]
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectS2\OrdirectS2\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(95, 139, true);
            WriteLiteral("\r\n<h2>Detail</h2>\r\n\r\n<div>\r\n    <h4>ReserveringDetailViewModel</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(235, 49, false);
#line 14 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectS2\OrdirectS2\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.ReserveringID));

#line default
#line hidden
            EndContext();
            BeginContext(284, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(328, 45, false);
#line 17 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectS2\OrdirectS2\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
       Write(Html.DisplayFor(model => model.ReserveringID));

#line default
#line hidden
            EndContext();
            BeginContext(373, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(417, 44, false);
#line 20 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectS2\OrdirectS2\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.datetime));

#line default
#line hidden
            EndContext();
            BeginContext(461, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(505, 40, false);
#line 23 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectS2\OrdirectS2\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
       Write(Html.DisplayFor(model => model.datetime));

#line default
#line hidden
            EndContext();
            BeginContext(545, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(589, 42, false);
#line 26 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectS2\OrdirectS2\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(631, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(675, 38, false);
#line 29 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectS2\OrdirectS2\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(713, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(757, 43, false);
#line 32 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectS2\OrdirectS2\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.KlantID));

#line default
#line hidden
            EndContext();
            BeginContext(800, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(844, 39, false);
#line 35 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectS2\OrdirectS2\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
       Write(Html.DisplayFor(model => model.KlantID));

#line default
#line hidden
            EndContext();
            BeginContext(883, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(927, 48, false);
#line 38 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectS2\OrdirectS2\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.RestaurantID));

#line default
#line hidden
            EndContext();
            BeginContext(975, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1019, 44, false);
#line 41 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectS2\OrdirectS2\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
       Write(Html.DisplayFor(model => model.RestaurantID));

#line default
#line hidden
            EndContext();
            BeginContext(1063, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1111, 65, false);
#line 46 "D:\Fontys Semester 2\Indiviueel\Git Bestanden\OrdirectS2\OrdirectS2\OrdirectS2\OrdirectWebsite\Views\Reservering\Detail.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.ReserveringID }));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1184, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acb17b3f4fa246e68c8bec65fc15e220", async() => {
                BeginContext(1206, 12, true);
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
            BeginContext(1222, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
