#pragma checksum "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20a6235a0886679b99980d3d350929ba303b4b47"
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
#line 3 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 4 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 5 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 6 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#line 7 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels.Components;

#line default
#line hidden
#line 8 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#line 9 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Contants;

#line default
#line hidden
#line 10 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Texto;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a6235a0886679b99980d3d350929ba303b4b47", @"/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2cd83e19214e30239a18602a7f0fd276d947335", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.Pedido>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
  
    ViewData["Title"] = "Index";
    decimal valorTotal = 0;

#line default
#line hidden
            BeginContext(104, 180, true);
            WriteLiteral("<br />\r\n<br />\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12 text-center\">\r\n            <h1>Pedido</h1>\r\n            <div class=\"numero-pedido\">nº ");
            EndContext();
            BeginContext(285, 8, false);
#line 12 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
                                     Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(293, 1, true);
            WriteLiteral("-");
            EndContext();
            BeginContext(295, 19, false);
#line 12 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
                                               Write(Model.TransactionId);

#line default
#line hidden
            EndContext();
            BeginContext(314, 292, true);
            WriteLiteral(@"</div>

            <table class=""table table-bordered"">
                <thread>
                    <tr>
                        <th>Nome</th>
                        <th>Quantidade</th>
                        <th>Valor</th>
                    </tr>
                </thread>

");
            EndContext();
#line 23 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
                 foreach (ProdutoItem produto in ViewBag.Produtos)
                {
                    valorTotal += (produto.UnidadesPedidas * produto.Valor);

#line default
#line hidden
            BeginContext(771, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(826, 12, false);
#line 27 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
                       Write(produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(838, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(874, 23, false);
#line 28 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
                       Write(produto.UnidadesPedidas);

#line default
#line hidden
            EndContext();
            BeginContext(897, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(964, 55, false);
#line 30 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
                        Write((produto.UnidadesPedidas * produto.Valor).ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(1020, 31, true);
            WriteLiteral("\r\n                            (");
            EndContext();
            BeginContext(1052, 27, false);
#line 31 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
                        Write(produto.Valor.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(1079, 66, true);
            WriteLiteral(" unid)\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 34 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1164, 98, true);
            WriteLiteral("\r\n                <tr>\r\n                    <td colspan=\"2\">Frete</td>\r\n                    <td>\r\n");
            EndContext();
#line 39 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
                          
                            var frete = Mascara.ConverterPagarMeIntToDecimal(ViewBag.Transacao.Shipping.Fee);
                            valorTotal += frete;
                        

#line default
#line hidden
            BeginContext(1478, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1503, 19, false);
#line 43 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
                   Write(frete.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(1522, 146, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td colspan=\"2\">TOTAL</td>\r\n                    <td>");
            EndContext();
            BeginContext(1669, 24, false);
#line 48 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
                   Write(valorTotal.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(1693, 54, true);
            WriteLiteral("</td>\r\n                </tr>\r\n            </table>\r\n\r\n");
            EndContext();
#line 52 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
             if(Model.FormaPagamento == MetodoPagamentoConstant.Boleto)
            {

#line default
#line hidden
            BeginContext(1835, 56, true);
            WriteLiteral("                <h3>Boleto</h3>\r\n                <iframe");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1891, "\"", 1925, 1);
#line 55 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 1897, ViewBag.Transacao.BoletoUrl, 1897, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1926, 110, true);
            WriteLiteral(" style=\"width: 100%; min-height: 400px; border: 1px solid #CCC;\"></iframe>\r\n                <a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2036, "\"", 2071, 1);
#line 56 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 2043, ViewBag.Transacao.BoletoUrl, 2043, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2072, 49, true);
            WriteLiteral(" class=\"btn btn-outline-secondary\">Imprimir</a>\r\n");
            EndContext();
#line 57 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2136, 52, true);
            WriteLiteral("            <br />\r\n            <br />\r\n            ");
            EndContext();
            BeginContext(2188, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20a6235a0886679b99980d3d350929ba303b4b4712403", async() => {
                BeginContext(2271, 16, true);
                WriteLiteral("Voltar a comprar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
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
            BeginContext(2291, 42, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaVirtual.Models.Pedido> Html { get; private set; }
    }
}
#pragma warning restore 1591
