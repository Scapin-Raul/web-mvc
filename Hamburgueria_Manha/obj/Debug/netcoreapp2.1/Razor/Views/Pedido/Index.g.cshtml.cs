#pragma checksum "C:\Users\46791749865\Desktop\web-mvc\Hamburgueria_Manha\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bdd6b6a0ba82f3566caa6e7e2976f698c06e810"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Index), @"mvc.1.0.view", @"/Views/Pedido/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/Index.cshtml", typeof(AspNetCore.Views_Pedido_Index))]
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
#line 1 "C:\Users\46791749865\Desktop\web-mvc\Hamburgueria_Manha\Views\_ViewImports.cshtml"
using Hamburgueria_Manha;

#line default
#line hidden
#line 2 "C:\Users\46791749865\Desktop\web-mvc\Hamburgueria_Manha\Views\_ViewImports.cshtml"
using Hamburgueria_Manha.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bdd6b6a0ba82f3566caa6e7e2976f698c06e810", @"/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2de7fa908a568c51a60502d109ce07fc8c93150c", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hamburgueria_Manha.ViewModels.PedidoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Pedido/RegistrarPedido"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\46791749865\Desktop\web-mvc\Hamburgueria_Manha\Views\Pedido\Index.cshtml"
  
    var user = (string) ViewData["User"];

#line default
#line hidden
            BeginContext(104, 10, true);
            WriteLiteral("<header>\r\n");
            EndContext();
#line 6 "C:\Users\46791749865\Desktop\web-mvc\Hamburgueria_Manha\Views\Pedido\Index.cshtml"
      
        Html.RenderPartial("_HeaderNavBar");
    

#line default
#line hidden
            BeginContext(175, 21, true);
            WriteLiteral("</header>\r\n\r\n<main>\r\n");
            EndContext();
#line 12 "C:\Users\46791749865\Desktop\web-mvc\Hamburgueria_Manha\Views\Pedido\Index.cshtml"
         if (!string.IsNullOrEmpty(Model.Cliente.Nome)){

#line default
#line hidden
            BeginContext(254, 25, true);
            WriteLiteral("            <h2>Pede aí, ");
            EndContext();
            BeginContext(280, 18, false);
#line 13 "C:\Users\46791749865\Desktop\web-mvc\Hamburgueria_Manha\Views\Pedido\Index.cshtml"
                    Write(Model.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(298, 8, true);
            WriteLiteral("!</h2>\r\n");
            EndContext();
#line 14 "C:\Users\46791749865\Desktop\web-mvc\Hamburgueria_Manha\Views\Pedido\Index.cshtml"
        }else{

#line default
#line hidden
            BeginContext(322, 38, true);
            WriteLiteral("            <h2>Pede aí, jovem!</h2>\r\n");
            EndContext();
#line 16 "C:\Users\46791749865\Desktop\web-mvc\Hamburgueria_Manha\Views\Pedido\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(371, 12, true);
            WriteLiteral("\r\n\r\n        ");
            EndContext();
            BeginContext(383, 2051, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fccaf77dc844d26828982debbbc514f", async() => {
                BeginContext(435, 201, true);
                WriteLiteral("\r\n            \r\n            <div>\r\n                <label for=\"nome\">Nome Completo</label>\r\n                <br />\r\n                <input id=\"nome\" type=\"text\" maxlength=\"20\" minlength=\"3\" name=\"nome\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 636, "\"", 663, 1);
#line 24 "C:\Users\46791749865\Desktop\web-mvc\Hamburgueria_Manha\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 644, Model.Cliente.Nome, 644, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(664, 219, true);
                WriteLiteral(" />\r\n            </div>\r\n\r\n            <div>\r\n                <label for=\"endereco\">Endereço</label>\r\n                <br />\r\n                <input id=\"endereco\" type=\"text\" maxlength=\"20\" minlength=\"3\" name=\"endereco\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 883, "\"", 914, 1);
#line 30 "C:\Users\46791749865\Desktop\web-mvc\Hamburgueria_Manha\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 891, Model.Cliente.Endereco, 891, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(915, 203, true);
                WriteLiteral(" />\r\n            </div>\r\n\r\n            <div>\r\n                <label for=\"telefone\">Telefone para contato</label>\r\n                <br />\r\n                <input id=\"telefone\" type=\"text\" name=\"telefone\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1118, "\"", 1149, 1);
#line 36 "C:\Users\46791749865\Desktop\web-mvc\Hamburgueria_Manha\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 1126, Model.Cliente.Telefone, 1126, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1150, 179, true);
                WriteLiteral("/>\r\n            </div>\r\n\r\n            <div>\r\n                <label for=\"email\">E-mail</label>\r\n                <br />\r\n                <input id=\"email\" type=\"email\" name=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1329, "\"", 1357, 1);
#line 42 "C:\Users\46791749865\Desktop\web-mvc\Hamburgueria_Manha\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 1337, Model.Cliente.Email, 1337, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1358, 250, true);
                WriteLiteral(" >\r\n            </div>\r\n\r\n            <div class=\"double-field\">\r\n                <div>\r\n                    <label for=\"hamburguer\">Hamburguer</label>\r\n                    <select id=\"hamburguer\" name=\"hamburguer\" required>\r\n                        ");
                EndContext();
                BeginContext(1608, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f6f22a45c554ea387e81ff549749683", async() => {
                    BeginContext(1643, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1661, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 50 "C:\Users\46791749865\Desktop\web-mvc\Hamburgueria_Manha\Views\Pedido\Index.cshtml"
                         foreach(var hamburguer in Model.Hamburgueres) {

#line default
#line hidden
                BeginContext(1737, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1765, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ae76685d1a449c09f6f1c99ccc32da8", async() => {
                    BeginContext(1797, 15, false);
#line 51 "C:\Users\46791749865\Desktop\web-mvc\Hamburgueria_Manha\Views\Pedido\Index.cshtml"
                                                      Write(hamburguer.Nome);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 51 "C:\Users\46791749865\Desktop\web-mvc\Hamburgueria_Manha\Views\Pedido\Index.cshtml"
                              WriteLiteral(hamburguer.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1821, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 52 "C:\Users\46791749865\Desktop\web-mvc\Hamburgueria_Manha\Views\Pedido\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(1850, 210, true);
                WriteLiteral("                    </select>\r\n                </div>\r\n                <div>\r\n                    <label for=\"shake\">Shake</label>\r\n                    <select id=\"shake\" name=\"shake\">\r\n                        ");
                EndContext();
                BeginContext(2060, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f6cb9c2229946e78a975f328a426295", async() => {
                    BeginContext(2095, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2113, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 59 "C:\Users\46791749865\Desktop\web-mvc\Hamburgueria_Manha\Views\Pedido\Index.cshtml"
                         foreach(var shake in Model.Shakes) {

#line default
#line hidden
                BeginContext(2178, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(2206, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ec41017d9ee4bd982d95c6d654ca605", async() => {
                    BeginContext(2233, 10, false);
#line 60 "C:\Users\46791749865\Desktop\web-mvc\Hamburgueria_Manha\Views\Pedido\Index.cshtml"
                                                 Write(shake.Nome);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 60 "C:\Users\46791749865\Desktop\web-mvc\Hamburgueria_Manha\Views\Pedido\Index.cshtml"
                              WriteLiteral(shake.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2252, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 61 "C:\Users\46791749865\Desktop\web-mvc\Hamburgueria_Manha\Views\Pedido\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(2281, 146, true);
                WriteLiteral("                    </select>\r\n                </div>\r\n            </div>\r\n            <input type=\"submit\" value=\"Finalizar pedido!\" />\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2434, 15, true);
            WriteLiteral("\r\n\r\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hamburgueria_Manha.ViewModels.PedidoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591