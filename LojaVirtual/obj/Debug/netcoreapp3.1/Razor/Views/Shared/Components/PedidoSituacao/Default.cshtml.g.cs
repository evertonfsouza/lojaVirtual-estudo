#pragma checksum "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\Shared\Components\PedidoSituacao\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6053648d1281fe74ccd27a099af8e41130257d18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PedidoSituacao_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PedidoSituacao/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6053648d1281fe74ccd27a099af8e41130257d18", @"/Views/Shared/Components/PedidoSituacao/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2cd83e19214e30239a18602a7f0fd276d947335", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PedidoSituacao_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PedidoSituacaoStatus>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\Shared\Components\PedidoSituacao\Default.cshtml"
  
    ViewData["Title"] = "Default";
    var quebraLinha = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\Shared\Components\PedidoSituacao\Default.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul class=\"timeline\" id=\"timeline\">\r\n");
#nullable restore
#line 10 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\Shared\Components\PedidoSituacao\Default.cshtml"
     foreach (var pedidoStatus in Model)
    {
        quebraLinha++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li");
            BeginWriteAttribute("class", " class=\"", 251, "\"", 313, 2);
            WriteAttributeValue("", 259, "li", 259, 2, true);
#nullable restore
#line 13 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\Shared\Components\PedidoSituacao\Default.cshtml"
WriteAttributeValue(" ", 261, (pedidoStatus.Concluido) ? pedidoStatus.Cor : "", 262, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"timestamp\">\r\n                <span class=\"date\"> ");
#nullable restore
#line 15 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\Shared\Components\PedidoSituacao\Default.cshtml"
                                Write((pedidoStatus.Data != null) ? pedidoStatus.Data.ToString() : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>\r\n            </div>\r\n            <div class=\"status\">\r\n                <h4> ");
#nullable restore
#line 18 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\Shared\Components\PedidoSituacao\Default.cshtml"
                Write(pedidoStatus.Situacao);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n            </div>\r\n        </li>\r\n");
#nullable restore
#line 21 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\Shared\Components\PedidoSituacao\Default.cshtml"

        if (quebraLinha == 5)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\Shared\Components\PedidoSituacao\Default.cshtml"
       Write(Html.Raw("</ul>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\Shared\Components\PedidoSituacao\Default.cshtml"
                              ;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\Shared\Components\PedidoSituacao\Default.cshtml"
       Write(Html.Raw("<ul class='timeline' id=\"timeline\">"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\Shared\Components\PedidoSituacao\Default.cshtml"
                                                              ;
            quebraLinha = 0;
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
#nullable restore
#line 30 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\Views\Shared\Components\PedidoSituacao\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PedidoSituacaoStatus>> Html { get; private set; }
    }
}
#pragma warning restore 1591
