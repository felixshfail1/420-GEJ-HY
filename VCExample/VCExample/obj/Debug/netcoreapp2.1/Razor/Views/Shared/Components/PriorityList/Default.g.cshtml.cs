#pragma checksum "C:\Users\hlapointe\Projects\GEJ\VCExample\VCExample\Views\Shared\Components\PriorityList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44cefae8e7266b3def2893d1f38d31fd2507ac08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PriorityList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PriorityList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/PriorityList/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_PriorityList_Default))]
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
#line 1 "C:\Users\hlapointe\Projects\GEJ\VCExample\VCExample\Views\_ViewImports.cshtml"
using VCExample;

#line default
#line hidden
#line 2 "C:\Users\hlapointe\Projects\GEJ\VCExample\VCExample\Views\_ViewImports.cshtml"
using VCExample.Models;

#line default
#line hidden
#line 3 "C:\Users\hlapointe\Projects\GEJ\VCExample\VCExample\Views\_ViewImports.cshtml"
using VCExample.ViewComponents;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44cefae8e7266b3def2893d1f38d31fd2507ac08", @"/Views/Shared/Components/PriorityList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acb180401975ee29727f4f93bbeefc2f8d554262", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PriorityList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ToDo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 108, true);
            WriteLiteral("\r\n<div class=\"bg-success m-1 p-1 text-white\">\r\n    <h2>Priority List</h2>\r\n</div>\r\n<ul class=\"list-group\">\r\n");
            EndContext();
#line 7 "C:\Users\hlapointe\Projects\GEJ\VCExample\VCExample\Views\Shared\Components\PriorityList\Default.cshtml"
     foreach (var item in Model) {

#line default
#line hidden
            BeginContext(170, 32, true);
            WriteLiteral("    <li class=\"list-group-item\">");
            EndContext();
            BeginContext(203, 9, false);
#line 8 "C:\Users\hlapointe\Projects\GEJ\VCExample\VCExample\Views\Shared\Components\PriorityList\Default.cshtml"
                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(212, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 9 "C:\Users\hlapointe\Projects\GEJ\VCExample\VCExample\Views\Shared\Components\PriorityList\Default.cshtml"
}

#line default
#line hidden
            BeginContext(222, 7, true);
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ToDo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
