#pragma checksum "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\ListagemCategoria.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1863ab19fb4aa4d479579fa23faac2686cb6187a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_ListagemCategoria), @"mvc.1.0.view", @"/Views/Produto/ListagemCategoria.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/ListagemCategoria.cshtml", typeof(AspNetCore.Views_Produto_ListagemCategoria))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1863ab19fb4aa4d479579fa23faac2686cb6187a", @"/Views/Produto/ListagemCategoria.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2cd83e19214e30239a18602a7f0fd276d947335", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_ListagemCategoria : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Categoria>
    {
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
        private global::AspNetCore.Views_Produto_ListagemCategoria.__Generated__ProdutoListagemViewComponentTagHelper __ProdutoListagemViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\ListagemCategoria.cshtml"
  
    ViewData["Title"] = "Categoria";

#line default
#line hidden
            BeginContext(63, 157, true);
            WriteLiteral("<br style=\"clear: both\" />\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <span id=\"breadcrumb\">Categoria > ");
            EndContext();
            BeginContext(221, 10, false);
#line 10 "C:\Users\Everton\Documents\GitHub\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\ListagemCategoria.cshtml"
                                         Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(231, 51, true);
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(282, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:produto-listagem", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1863ab19fb4aa4d479579fa23faac2686cb6187a5229", async() => {
            }
            );
            __ProdutoListagemViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Produto_ListagemCategoria.__Generated__ProdutoListagemViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__ProdutoListagemViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Categoria> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:produto-listagem")]
        public class __Generated__ProdutoListagemViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
            public __Generated__ProdutoListagemViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                _helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
            {
                (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var content = await _helper.InvokeAsync("ProdutoListagem", new {  });
                output.TagName = null;
                output.Content.SetHtmlContent(content);
            }
        }
    }
}
#pragma warning restore 1591