#pragma checksum "E:\Back_end\Hermaken_MVC\MVC_Hermaken\Views\HelloWorld\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d85e726902f8aeba71cad765ea975ab558bcbcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloWorld_Welcome), @"mvc.1.0.view", @"/Views/HelloWorld/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HelloWorld/Welcome.cshtml", typeof(AspNetCore.Views_HelloWorld_Welcome))]
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
#line 1 "E:\Back_end\Hermaken_MVC\MVC_Hermaken\Views\_ViewImports.cshtml"
using MVC_Hermaken;

#line default
#line hidden
#line 2 "E:\Back_end\Hermaken_MVC\MVC_Hermaken\Views\_ViewImports.cshtml"
using MVC_Hermaken.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d85e726902f8aeba71cad765ea975ab558bcbcf", @"/Views/HelloWorld/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d7201adbfb0188658882fb51c461c9705a05891", @"/Views/_ViewImports.cshtml")]
    public class Views_HelloWorld_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\Back_end\Hermaken_MVC\MVC_Hermaken\Views\HelloWorld\Welcome.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
            BeginContext(45, 28, true);
            WriteLiteral("\r\n<h1>Welcome</h1>\r\n\r\n<ul>\r\n");
            EndContext();
#line 9 "E:\Back_end\Hermaken_MVC\MVC_Hermaken\Views\HelloWorld\Welcome.cshtml"
     for (int i = 0; i < (int)ViewData["NumTimes"]; i++)
    {

#line default
#line hidden
            BeginContext(138, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(151, 19, false);
#line 11 "E:\Back_end\Hermaken_MVC\MVC_Hermaken\Views\HelloWorld\Welcome.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(170, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 12 "E:\Back_end\Hermaken_MVC\MVC_Hermaken\Views\HelloWorld\Welcome.cshtml"
    }

#line default
#line hidden
            BeginContext(184, 9, true);
            WriteLiteral("</ul>\r\n\r\n");
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
