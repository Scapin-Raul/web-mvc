#pragma checksum "C:\Users\46791749865\Desktop\PROJETOS WEBMVC\EX2\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa5d8156ef392dd9a06c748aae1adf9ffbbdc888"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Index.cshtml", typeof(AspNetCore.Views_Usuario_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa5d8156ef392dd9a06c748aae1adf9ffbbdc888", @"/Views/Usuario/Index.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\46791749865\Desktop\PROJETOS WEBMVC\EX2\Views\Usuario\Index.cshtml"
  
    Layout = "MasterPage";
    ViewBag.Title = "Cadastro de Usuários";

#line default
#line hidden
            BeginContext(80, 536, true);
            WriteLiteral(@"<h1>Bem Vindo!</h1>

<form action=""/Usuario/Cadastrar"" method=""POST"">
    <label>
        Nome:
        <input type=""text"" name=""nome"">
    </label>
    <br>
    <label >
        Email:
        <input type=""email"" name=""email"">
    </label>
    <br>
    <label >
        Senha:
        <input type=""password"" name=""senha"">
    </label>
    <br>
    <label >
        Data Nascimento:
        <input type=""date"" name=""datanascimento"">
    </label>
    <br>
    <input type=""submit"" value=""Cadastrar"">

</form>

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