#pragma checksum "C:\Users\46791749865\Desktop\web mvc\Views\Musica\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12c48279073b06b10453312f37a6be8a44455a4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Musica_Welcome), @"mvc.1.0.view", @"/Views/Musica/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Musica/Welcome.cshtml", typeof(AspNetCore.Views_Musica_Welcome))]
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
#line 1 "C:\Users\46791749865\Desktop\web mvc\Views\_ViewImports.cshtml"
using web_mvc;

#line default
#line hidden
#line 2 "C:\Users\46791749865\Desktop\web mvc\Views\_ViewImports.cshtml"
using web_mvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12c48279073b06b10453312f37a6be8a44455a4b", @"/Views/Musica/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f0513abca64e3317724a6566a5d13224754bc2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Musica_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<web_mvc.Models.Musica>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\46791749865\Desktop\web mvc\Views\Musica\Welcome.cshtml"
  
    ViewData["Title"] = "Bem Vindo(a)";

#line default
#line hidden
            BeginContext(111, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(118, 17, false);
#line 6 "C:\Users\46791749865\Desktop\web mvc\Views\Musica\Welcome.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(135, 13, true);
            WriteLiteral("</h2>\r\n\r\n<h3>");
            EndContext();
            BeginContext(149, 20, false);
#line 8 "C:\Users\46791749865\Desktop\web mvc\Views\Musica\Welcome.cshtml"
Write(ViewData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(169, 11, true);
            WriteLiteral("</h2>\r\n\r\n\r\n");
            EndContext();
#line 11 "C:\Users\46791749865\Desktop\web mvc\Views\Musica\Welcome.cshtml"
 foreach(var i in @Model){
    

#line default
#line hidden
            BeginContext(214, 32, true);
            WriteLiteral("    <p><strong>Titulo:</strong> ");
            EndContext();
            BeginContext(247, 8, false);
#line 13 "C:\Users\46791749865\Desktop\web mvc\Views\Musica\Welcome.cshtml"
                           Write(i.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(255, 38, true);
            WriteLiteral("</p>\r\n    <p><strong>Estilo:</strong> ");
            EndContext();
            BeginContext(294, 8, false);
#line 14 "C:\Users\46791749865\Desktop\web mvc\Views\Musica\Welcome.cshtml"
                           Write(i.Estilo);

#line default
#line hidden
            EndContext();
            BeginContext(302, 42, true);
            WriteLiteral("</p>\r\n    <p><strong>Compositor:</strong> ");
            EndContext();
            BeginContext(345, 12, false);
#line 15 "C:\Users\46791749865\Desktop\web mvc\Views\Musica\Welcome.cshtml"
                               Write(i.Compositor);

#line default
#line hidden
            EndContext();
            BeginContext(357, 16, true);
            WriteLiteral("</p>\r\n    <BR>\r\n");
            EndContext();
#line 17 "C:\Users\46791749865\Desktop\web mvc\Views\Musica\Welcome.cshtml"
    
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<web_mvc.Models.Musica>> Html { get; private set; }
    }
}
#pragma warning restore 1591