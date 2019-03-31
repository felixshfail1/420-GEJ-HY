#pragma checksum "C:\Users\hlapointe\Projects\GEJ\ICExample\ICExample\Views\Claims\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b25d8d9f878d91b9f99332c00cdeb21957f6acd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Claims_Index), @"mvc.1.0.view", @"/Views/Claims/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Claims/Index.cshtml", typeof(AspNetCore.Views_Claims_Index))]
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
#line 1 "C:\Users\hlapointe\Projects\GEJ\ICExample\ICExample\Views\_VIewImports.cshtml"
using ICExample;

#line default
#line hidden
#line 2 "C:\Users\hlapointe\Projects\GEJ\ICExample\ICExample\Views\_VIewImports.cshtml"
using ICExample.Models;

#line default
#line hidden
#line 3 "C:\Users\hlapointe\Projects\GEJ\ICExample\ICExample\Views\_VIewImports.cshtml"
using ICExample.Models.User;

#line default
#line hidden
#line 4 "C:\Users\hlapointe\Projects\GEJ\ICExample\ICExample\Views\_VIewImports.cshtml"
using ICExample.Models.Role;

#line default
#line hidden
#line 5 "C:\Users\hlapointe\Projects\GEJ\ICExample\ICExample\Views\_VIewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#line 6 "C:\Users\hlapointe\Projects\GEJ\ICExample\ICExample\Views\_VIewImports.cshtml"
using ICExample.Models.Account;

#line default
#line hidden
#line 7 "C:\Users\hlapointe\Projects\GEJ\ICExample\ICExample\Views\_VIewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b25d8d9f878d91b9f99332c00cdeb21957f6acd3", @"/Views/Claims/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11228a07647822158461c3d99c6e1f0cc1286f26", @"/Views/_VIewImports.cshtml")]
    public class Views_Claims_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Claim>>
    {
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
        private global::ICExample.Infrastructure.ClaimInfosTagHelper __ICExample_Infrastructure_ClaimInfosTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\hlapointe\Projects\GEJ\ICExample\ICExample\Views\Claims\Index.cshtml"
   Layout = "_Layout"; 

#line default
#line hidden
            BeginContext(55, 327, true);
            WriteLiteral(@"
<div class=""bg-primary my-1 p-1 text-white"">
    <h4>Claims</h4>
</div>

<table class=""table table-striped table-bordered my-1"">
    <thead class=""thead-dark"">
        <tr>
            <th>Subject</th>
            <th>Issuer</th>
            <th>Type</th>
            <th>Value</th>
        </tr>
    </thead>

");
            EndContext();
#line 19 "C:\Users\hlapointe\Projects\GEJ\ICExample\ICExample\Views\Claims\Index.cshtml"
     if(Model == null || !Model.Any()) {

#line default
#line hidden
            BeginContext(424, 69, true);
            WriteLiteral("        <tr><td colspan=\"4\" class=\"text-center\">No Claims</td></tr>\r\n");
            EndContext();
#line 21 "C:\Users\hlapointe\Projects\GEJ\ICExample\ICExample\Views\Claims\Index.cshtml"

    } else {
        

#line default
#line hidden
#line 23 "C:\Users\hlapointe\Projects\GEJ\ICExample\ICExample\Views\Claims\Index.cshtml"
         foreach(var claim in Model.OrderBy(x => x.Type)) {

#line default
#line hidden
            BeginContext(570, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(609, 18, false);
#line 25 "C:\Users\hlapointe\Projects\GEJ\ICExample\ICExample\Views\Claims\Index.cshtml"
               Write(claim.Subject.Name);

#line default
#line hidden
            EndContext();
            BeginContext(627, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(655, 12, false);
#line 26 "C:\Users\hlapointe\Projects\GEJ\ICExample\ICExample\Views\Claims\Index.cshtml"
               Write(claim.Issuer);

#line default
#line hidden
            EndContext();
            BeginContext(667, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(694, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("claim-infos", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69f063ad96a14bf0bc7c0d4fae34237e", async() => {
            }
            );
            __ICExample_Infrastructure_ClaimInfosTagHelper = CreateTagHelper<global::ICExample.Infrastructure.ClaimInfosTagHelper>();
            __tagHelperExecutionContext.Add(__ICExample_Infrastructure_ClaimInfosTagHelper);
            BeginWriteTagHelperAttribute();
#line 27 "C:\Users\hlapointe\Projects\GEJ\ICExample\ICExample\Views\Claims\Index.cshtml"
                                 WriteLiteral(claim.Type);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __ICExample_Infrastructure_ClaimInfosTagHelper.ClaimType = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("claim-type", __ICExample_Infrastructure_ClaimInfosTagHelper.ClaimType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(746, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(774, 11, false);
#line 28 "C:\Users\hlapointe\Projects\GEJ\ICExample\ICExample\Views\Claims\Index.cshtml"
               Write(claim.Value);

#line default
#line hidden
            EndContext();
            BeginContext(785, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 30 "C:\Users\hlapointe\Projects\GEJ\ICExample\ICExample\Views\Claims\Index.cshtml"
        }

#line default
#line hidden
#line 30 "C:\Users\hlapointe\Projects\GEJ\ICExample\ICExample\Views\Claims\Index.cshtml"
         
    }

#line default
#line hidden
            BeginContext(829, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Claim>> Html { get; private set; }
    }
}
#pragma warning restore 1591
