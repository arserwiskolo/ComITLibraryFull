#pragma checksum "C:\Users\serwi\Documents\ComITLibraryFull\comitlibraryMVC\Views\Word\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f74440cd67704cccfe793b7e8171459f951795de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Word_index), @"mvc.1.0.view", @"/Views/Word/index.cshtml")]
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
#line 1 "C:\Users\serwi\Documents\ComITLibraryFull\comitlibraryMVC\Views\_ViewImports.cshtml"
using ComITLibraryMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\serwi\Documents\ComITLibraryFull\comitlibraryMVC\Views\_ViewImports.cshtml"
using ComITLibraryMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\serwi\Documents\ComITLibraryFull\comitlibraryMVC\Views\Word\index.cshtml"
using WordGuess.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74440cd67704cccfe793b7e8171459f951795de", @"/Views/Word/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87576f57116a508ef8395f7780c1f59165d14e54", @"/Views/_ViewImports.cshtml")]
    public class Views_Word_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Word>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    List of Books\r\n</div>\r\n\r\n\r\n<hr/>\r\n<div>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Category</th>\r\n        <th>Value</th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\serwi\Documents\ComITLibraryFull\comitlibraryMVC\Views\Word\index.cshtml"
     for (int i = 0; i < Model.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\serwi\Documents\ComITLibraryFull\comitlibraryMVC\Views\Word\index.cshtml"
               Write(Model[i].Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\serwi\Documents\ComITLibraryFull\comitlibraryMVC\Views\Word\index.cshtml"
               Write(Model[i].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </div>\r\n");
#nullable restore
#line 24 "C:\Users\serwi\Documents\ComITLibraryFull\comitlibraryMVC\Views\Word\index.cshtml"
        
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n    \r\n\r\n\r\n\r\n");
            WriteLiteral("</table>\r\n\r\n\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Word>> Html { get; private set; }
    }
}
#pragma warning restore 1591