#pragma checksum "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aecbf74f203a537cc1f8ae27752c5a4ef294ef1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cliente_Views_EnderecoEntrega_Index), @"mvc.1.0.view", @"/Areas/Cliente/Views/EnderecoEntrega/Index.cshtml")]
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
#line 3 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Texto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Json.Resolver;

#line default
#line hidden
#nullable disable
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
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 1 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
  
    ViewData["Title"] = "Listagem de endereços para entrega";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <br />\r\n    <br />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aecbf74f203a537cc1f8ae27752c5a4ef294ef1d6986", async() => {
                WriteLiteral("Voltar");
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
            WriteLiteral("\r\n            <br />\r\n");
#nullable restore
#line 13 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
               await Html.RenderPartialAsync("~/Views/Shared/_Mensagem.cshtml"); 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <br />
            <table class=""table table-hover"">
                <tbody>
                    <tr>
                        <td>
                            <label for=""0-end"">
                                <strong>Nome: </strong> Endereço do cliente.
                                <p>
                                    ");
#nullable restore
#line 22 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                               Write(ViewBag.Cliente.CEP);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 22 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                      Write(ViewBag.Cliente.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 22 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                                               Write(ViewBag.Cliente.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 22 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                                                                        Write(ViewBag.Cliente.Bairro);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 22 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                                                                                                 Write(ViewBag.Cliente.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 22 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                                                                                                                            Write(ViewBag.Cliente.Complemento);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 22 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                                                                                                                                                          Write(ViewBag.Cliente.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </label>\r\n                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aecbf74f203a537cc1f8ae27752c5a4ef294ef1d11949", async() => {
                WriteLiteral("Editar");
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
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n\r\n");
#nullable restore
#line 31 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                     foreach (EnderecoEntrega endereco in ViewBag.Enderecos)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <label");
            BeginWriteAttribute("for", " for=\"", 1405, "\"", 1427, 2);
#nullable restore
#line 35 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
WriteAttributeValue("", 1411, endereco.Id, 1411, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1423, "-end", 1423, 4, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <strong>Nome: </strong> ");
#nullable restore
#line 36 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                       Write(endereco.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <p>\r\n                                        ");
#nullable restore
#line 38 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                   Write(endereco.CEP);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 38 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                   Write(endereco.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 38 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                                     Write(endereco.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 38 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                                                       Write(endereco.Bairro);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 38 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                                                                         Write(endereco.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 38 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                                                                                             Write(endereco.Complemento);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 38 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                                                                                                                    Write(endereco.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                </label>\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aecbf74f203a537cc1f8ae27752c5a4ef294ef1d17439", async() => {
                WriteLiteral("Editar");
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
#nullable restore
#line 43 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                            WriteLiteral(endereco.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aecbf74f203a537cc1f8ae27752c5a4ef294ef1d19692", async() => {
                WriteLiteral("Remover");
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
#nullable restore
#line 44 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                                                          WriteLiteral(endereco.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 47 "C:\Users\Everton\Documents\GitHub\lojaVirtual-estudo\LojaVirtual\LojaVirtual\Areas\Cliente\Views\EnderecoEntrega\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </tbody>\r\n            </table>\r\n\r\n\r\n            <div class=\"text-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aecbf74f203a537cc1f8ae27752c5a4ef294ef1d22370", async() => {
                WriteLiteral("Cadastrar novo endereço");
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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