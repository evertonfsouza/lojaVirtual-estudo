#pragma checksum "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aecbf74f203a537cc1f8ae27752c5a4ef294ef1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cliente_Views_EnderecoEntrega_Index), @"mvc.1.0.view", @"/Areas/Cliente/Views/EnderecoEntrega/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Cliente/Views/EnderecoEntrega/Index.cshtml", typeof(AspNetCore.Areas_Cliente_Views_EnderecoEntrega_Index))]
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
#line 3 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 4 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#line 5 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 6 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 7 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#line 8 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 9 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Texto;

#line default
#line hidden
#line 10 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Json.Resolver;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aecbf74f203a537cc1f8ae27752c5a4ef294ef1d", @"/Areas/Cliente/Views/EnderecoEntrega/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c06482c6d69c88a4c3bb64f1a8dc72f1babff4e", @"/Areas/Cliente/Views/_ViewImports.cshtml")]
    public class Areas_Cliente_Views_EnderecoEntrega_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Atualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Excluir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
  
    ViewData["Title"] = "Listagem de endereços para entrega";

#line default
#line hidden
            BeginContext(70, 121, true);
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <br />\r\n    <br />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
            EndContext();
            BeginContext(191, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aecbf74f203a537cc1f8ae27752c5a4ef294ef1d6808", async() => {
                BeginContext(270, 6, true);
                WriteLiteral("Voltar");
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
            BeginContext(280, 22, true);
            WriteLiteral("\r\n            <br />\r\n");
            EndContext();
#line 13 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
               await Html.RenderPartialAsync("~/Views/Shared/_Mensagem.cshtml"); 

#line default
#line hidden
            BeginContext(386, 348, true);
            WriteLiteral(@"            <br />
            <table class=""table table-hover"">
                <tbody>
                    <tr>
                        <td>
                            <label for=""0-end"">
                                <strong>Nome: </strong> Endereço do cliente.
                                <p>
                                    ");
            EndContext();
            BeginContext(735, 19, false);
#line 22 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                               Write(ViewBag.Cliente.CEP);

#line default
#line hidden
            EndContext();
            BeginContext(754, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(758, 22, false);
#line 22 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                      Write(ViewBag.Cliente.Estado);

#line default
#line hidden
            EndContext();
            BeginContext(780, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(783, 22, false);
#line 22 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                                               Write(ViewBag.Cliente.Cidade);

#line default
#line hidden
            EndContext();
            BeginContext(805, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(808, 22, false);
#line 22 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                                                                        Write(ViewBag.Cliente.Bairro);

#line default
#line hidden
            EndContext();
            BeginContext(830, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(833, 24, false);
#line 22 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                                                                                                 Write(ViewBag.Cliente.Endereco);

#line default
#line hidden
            EndContext();
            BeginContext(857, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(860, 27, false);
#line 22 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                                                                                                                            Write(ViewBag.Cliente.Complemento);

#line default
#line hidden
            EndContext();
            BeginContext(887, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(890, 22, false);
#line 22 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                                                                                                                                                          Write(ViewBag.Cliente.Numero);

#line default
#line hidden
            EndContext();
            BeginContext(912, 167, true);
            WriteLiteral("\r\n                                </p>\r\n                            </label>\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1079, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aecbf74f203a537cc1f8ae27752c5a4ef294ef1d12665", async() => {
                BeginContext(1130, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1140, 62, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n\r\n");
            EndContext();
#line 31 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                     foreach (EnderecoEntrega endereco in ViewBag.Enderecos)
                    {

#line default
#line hidden
            BeginContext(1303, 102, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1405, "\"", 1427, 2);
#line 35 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
WriteAttributeValue("", 1411, endereco.Id, 1411, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1423, "-end", 1423, 4, true);
            EndWriteAttribute();
            BeginContext(1428, 63, true);
            WriteLiteral(">\r\n                                    <strong>Nome: </strong> ");
            EndContext();
            BeginContext(1492, 13, false);
#line 36 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                       Write(endereco.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1505, 83, true);
            WriteLiteral("\r\n                                    <p>\r\n                                        ");
            EndContext();
            BeginContext(1589, 12, false);
#line 38 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                   Write(endereco.CEP);

#line default
#line hidden
            EndContext();
            BeginContext(1601, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(1605, 15, false);
#line 38 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                   Write(endereco.Estado);

#line default
#line hidden
            EndContext();
            BeginContext(1620, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1623, 15, false);
#line 38 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                                     Write(endereco.Cidade);

#line default
#line hidden
            EndContext();
            BeginContext(1638, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1641, 15, false);
#line 38 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                                                       Write(endereco.Bairro);

#line default
#line hidden
            EndContext();
            BeginContext(1656, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1659, 17, false);
#line 38 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                                                                         Write(endereco.Endereco);

#line default
#line hidden
            EndContext();
            BeginContext(1676, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1679, 20, false);
#line 38 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                                                                                             Write(endereco.Complemento);

#line default
#line hidden
            EndContext();
            BeginContext(1699, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1702, 15, false);
#line 38 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                                                                                                                    Write(endereco.Numero);

#line default
#line hidden
            EndContext();
            BeginContext(1717, 187, true);
            WriteLiteral("\r\n                                    </p>\r\n                                </label>\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1904, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aecbf74f203a537cc1f8ae27752c5a4ef294ef1d19187", async() => {
                BeginContext(1958, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                            WriteLiteral(endereco.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1968, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2002, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aecbf74f203a537cc1f8ae27752c5a4ef294ef1d21613", async() => {
                BeginContext(2054, 7, true);
                WriteLiteral("Remover");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                          WriteLiteral(endereco.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2065, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 47 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2156, 111, true);
            WriteLiteral("\r\n\r\n                </tbody>\r\n            </table>\r\n\r\n\r\n            <div class=\"text-center\">\r\n                ");
            EndContext();
            BeginContext(2267, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aecbf74f203a537cc1f8ae27752c5a4ef294ef1d24490", async() => {
                BeginContext(2325, 23, true);
                WriteLiteral("Cadastrar novo endereço");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2352, 62, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
