#pragma checksum "/Users/elvismakia/Downloads/WeddingPlanner/Views/Wedding/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cee1d885f7251e37737709d46ec4311fe9f94ed9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wedding_Show), @"mvc.1.0.view", @"/Views/Wedding/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Wedding/Show.cshtml", typeof(AspNetCore.Views_Wedding_Show))]
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
#line 1 "/Users/elvismakia/Downloads/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#line 2 "/Users/elvismakia/Downloads/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cee1d885f7251e37737709d46ec4311fe9f94ed9", @"/Views/Wedding/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Wedding_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wedding>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Wedding", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(16, 30, true);
            WriteLiteral("\n\n<div class=\"container\">\n    ");
            EndContext();
            BeginContext(46, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf7cafdae7cd488abfed212361751020", async() => {
                BeginContext(93, 18, true);
                WriteLiteral("<h1>Dashboard</h1>");
                EndContext();
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
            EndContext();
            BeginContext(115, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6946763447134d7ab6a8a47ad87a251e", async() => {
                BeginContext(163, 16, true);
                WriteLiteral("<h1>Log Out</h1>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(183, 22, true);
            WriteLiteral("<hr>\n    <h1>Wedding: ");
            EndContext();
            BeginContext(206, 11, false);
#line 6 "/Users/elvismakia/Downloads/WeddingPlanner/Views/Wedding/Show.cshtml"
            Write(Model.Bride);

#line default
#line hidden
            EndContext();
            BeginContext(217, 5, true);
            WriteLiteral(" and ");
            EndContext();
            BeginContext(223, 11, false);
#line 6 "/Users/elvismakia/Downloads/WeddingPlanner/Views/Wedding/Show.cshtml"
                             Write(Model.Groom);

#line default
#line hidden
            EndContext();
            BeginContext(234, 35, true);
            WriteLiteral("   </h1>\n    <hr>\n    <h1>Planner: ");
            EndContext();
            BeginContext(270, 22, false);
#line 8 "/Users/elvismakia/Downloads/WeddingPlanner/Views/Wedding/Show.cshtml"
            Write(Model.Planner.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(292, 32, true);
            WriteLiteral("  </h1>\n    <hr>\n\n    <h1>Date: ");
            EndContext();
            BeginContext(325, 24, false);
#line 11 "/Users/elvismakia/Downloads/WeddingPlanner/Views/Wedding/Show.cshtml"
         Write(Model.Date.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(349, 37, true);
            WriteLiteral(" </h1><hr>\n\n      <h1><strong>Venue: ");
            EndContext();
            BeginContext(387, 11, false);
#line 13 "/Users/elvismakia/Downloads/WeddingPlanner/Views/Wedding/Show.cshtml"
                    Write(Model.Venue);

#line default
#line hidden
            EndContext();
            BeginContext(398, 60, true);
            WriteLiteral(" </strong></h1><hr>\n\n    <h1><strong>Guests:</strong></h1>\n\n");
            EndContext();
#line 17 "/Users/elvismakia/Downloads/WeddingPlanner/Views/Wedding/Show.cshtml"
     foreach (var rsvp in @Model.Responses)

    {

#line default
#line hidden
            BeginContext(509, 12, true);
            WriteLiteral("        <h1>");
            EndContext();
            BeginContext(522, 19, false);
#line 20 "/Users/elvismakia/Downloads/WeddingPlanner/Views/Wedding/Show.cshtml"
       Write(rsvp.Guest.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(541, 6, true);
            WriteLiteral("</h1>\n");
            EndContext();
#line 21 "/Users/elvismakia/Downloads/WeddingPlanner/Views/Wedding/Show.cshtml"
    }

#line default
#line hidden
            BeginContext(553, 9, true);
            WriteLiteral("\n\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wedding> Html { get; private set; }
    }
}
#pragma warning restore 1591