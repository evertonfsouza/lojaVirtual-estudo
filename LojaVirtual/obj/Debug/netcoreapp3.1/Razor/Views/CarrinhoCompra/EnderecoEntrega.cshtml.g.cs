#pragma checksum "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5ebc1220909062f1d9f9bbc92a62ee7ae88f1bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CarrinhoCompra_EnderecoEntrega), @"mvc.1.0.view", @"/Views/CarrinhoCompra/EnderecoEntrega.cshtml")]
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
#line 3 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Contants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Texto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5ebc1220909062f1d9f9bbc92a62ee7ae88f1bc", @"/Views/CarrinhoCompra/EnderecoEntrega.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2cd83e19214e30239a18602a7f0fd276d947335", @"/Views/_ViewImports.cshtml")]
    public class Views_CarrinhoCompra_EnderecoEntrega : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "EnderecoEntrega", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pagamento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-continuar disabled"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
  
    ViewData["Title"] = "EnderecoEntrega";

    var produtos = (List<ProdutoItem>)ViewBag.Produtos;
    decimal total = 0;

    foreach (ProdutoItem produto in produtos)
    {
        decimal resultado = produto.Valor * produto.UnidadesPedidas;
        total += resultado;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <br />\r\n    <br />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n");
#nullable restore
#line 20 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
               await Html.RenderPartialAsync("~/Views/Shared/_Mensagem.cshtml"); 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <table class=""table table-hover"">
                <tbody>
                    <tr>
                        <th scope=""row"">
                            <input type=""radio"" name=""endereco"" value=""0"" id=""0-end"" />
                            <input type=""hidden"" name=""cep""");
            BeginWriteAttribute("value", " value=\"", 779, "\"", 807, 1);
#nullable restore
#line 27 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
WriteAttributeValue("", 787, ViewBag.Cliente.CEP, 787, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        </th>
                        <td>
                            <label for=""0-end"">
                                <strong>Nome: </strong> Endereço do cliente.
                                <p>
                                    ");
#nullable restore
#line 33 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                               Write(ViewBag.Cliente.CEP);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 33 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                      Write(ViewBag.Cliente.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 33 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                                               Write(ViewBag.Cliente.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 33 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                                                                        Write(ViewBag.Cliente.Bairro);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 33 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                                                                                                 Write(ViewBag.Cliente.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 33 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                                                                                                                            Write(ViewBag.Cliente.Complemento);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 33 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                                                                                                                                                          Write(ViewBag.Cliente.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </label>\r\n                        </td>\r\n                    </tr>\r\n\r\n");
#nullable restore
#line 39 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                     foreach (EnderecoEntrega endereco in ViewBag.Enderecos)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">\r\n                                <input type=\"radio\" name=\"endereco\"");
            BeginWriteAttribute("value", " value=\"", 1634, "\"", 1654, 1);
#nullable restore
#line 43 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
WriteAttributeValue("", 1642, endereco.Id, 1642, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1655, "\"", 1676, 2);
#nullable restore
#line 43 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
WriteAttributeValue("", 1660, endereco.Id, 1660, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1672, "-end", 1672, 4, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <input type=\"hidden\" name=\"cep\"");
            BeginWriteAttribute("value", " value=\"", 1745, "\"", 1766, 1);
#nullable restore
#line 44 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
WriteAttributeValue("", 1753, endereco.CEP, 1753, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            </th>\r\n                            <td>\r\n                                <label");
            BeginWriteAttribute("for", " for=\"", 1879, "\"", 1901, 2);
#nullable restore
#line 47 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
WriteAttributeValue("", 1885, endereco.Id, 1885, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1897, "-end", 1897, 4, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <strong>Nome: </strong> ");
#nullable restore
#line 48 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                       Write(endereco.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <p>\r\n                                        ");
#nullable restore
#line 50 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                   Write(endereco.CEP);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 50 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                   Write(endereco.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 50 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                                     Write(endereco.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 50 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                                                       Write(endereco.Bairro);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 50 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                                                                         Write(endereco.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 50 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                                                                                             Write(endereco.Complemento);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 50 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                                                                                                                    Write(endereco.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                </label>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 55 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </tbody>\r\n            </table>\r\n\r\n\r\n\r\n            <div class=\"text-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5ebc1220909062f1d9f9bbc92a62ee7ae88f1bc16768", async() => {
                WriteLiteral("Cadastrar novo endereço");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                                                                       WriteLiteral(Url.Action("EnderecoEntrega", "CarrinhoCompra", new { area = ""}));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>

            <br />
            <div class=""card-group"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">-</h5>
                        <p class=""card-text"">-</p>
                    </div>
                    <div class=""card-footer"">
                        <small class=""text-muted"">
                            -
                        </small>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">-</h5>
                        <p class=""card-text"">-</p>
                    </div>
                    <div class=""card-footer"">
                        <small class=""text-muted"">
                            -
                        </small>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-body""");
            WriteLiteral(@">
                        <h5 class=""card-title"">-</h5>
                        <p class=""card-text"">-</p>
                    </div>
                    <div class=""card-footer"">
                        <small class=""text-muted"">
                            -
                        </small>
                    </div>
                </div>
            </div>
            <br />
            <div class=""card-group"">
                <div class=""card"">

                    <div class=""card-body"">
                        <h5 class=""card-title"">Produtos</h5>
                        <p class=""card-text texto-produto"">");
#nullable restore
#line 109 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                      Write(total.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

                    </div>
                </div>
                <div class=""card"">

                    <div class=""card-body"">
                        <h5 class=""card-title"">Frete</h5>
                        <p class=""card-text texto-frete"">-</p>
                    </div>
                </div>
                <div class=""card"">

                    <div class=""card-body"">
                        <h5 class=""card-title"">Total</h5>
                        <p class=""card-text texto-total"">-</p>
                    </div>
                </div>
            </div>


            <br />
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5ebc1220909062f1d9f9bbc92a62ee7ae88f1bc22280", async() => {
                WriteLiteral("Continuar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
