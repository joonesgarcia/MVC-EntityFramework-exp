#pragma checksum "C:\temp\VB\WebExample\WebExample\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a314214480da139bbdbe6949160778847599d892"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\temp\VB\WebExample\WebExample\Views\_ViewImports.cshtml"
using WebExample;

#line default
#line hidden
#line 2 "C:\temp\VB\WebExample\WebExample\Views\_ViewImports.cshtml"
using WebExample.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a314214480da139bbdbe6949160778847599d892", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d21f00a1229ec598da07e323f8db7284f027acf3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\temp\VB\WebExample\WebExample\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(41, 9, true);
            WriteLiteral("\r\n<\r\n<h2>");
            EndContext();
            BeginContext(51, 17, false);
#line 6 "C:\temp\VB\WebExample\WebExample\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(68, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(80, 19, false);
#line 7 "C:\temp\VB\WebExample\WebExample\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(99, 28, true);
            WriteLiteral("</h3>\r\n\r\n<p>Made by <strong>");
            EndContext();
            BeginContext(128, 19, false);
#line 9 "C:\temp\VB\WebExample\WebExample\Views\Home\About.cshtml"
              Write(ViewData["creator"]);

#line default
#line hidden
            EndContext();
            BeginContext(147, 286, true);
            WriteLiteral(@" </strong ></p>

<address>
    <strong> GitHub: <a href=""https://github.com/joonesgarcia""> github.com/joonesgarcia </a></strong> <br/>
    <strong> LinkedIn: <a href=""https://www.linkedin.com/in/jo%C3%A3o-garcia-768740140""> linkedin.com/joão-garcia </a></strong>

</address>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
