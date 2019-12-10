#pragma checksum "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f39f5c49a99d5f1b8487dbfc85f0aa4951966d25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Historico), @"mvc.1.0.view", @"/Views/Cliente/Historico.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Historico.cshtml", typeof(AspNetCore.Views_Cliente_Historico))]
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
#line 1 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\_ViewImports.cshtml"
using RoleTop;

#line default
#line hidden
#line 2 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\_ViewImports.cshtml"
using RoleTop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f39f5c49a99d5f1b8487dbfc85f0aa4951966d25", @"/Views/Cliente/Historico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8fc0cfda6b2bb54f88e5d7a55c241985d2df4ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Historico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTop.ViewModels.HistoricoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
  
    ViewData["Title"] = "Orcamentos - RoleTop";
    ViewData["H2"] = "Histórico de Orcamentos";

#line default
#line hidden
            BeginContext(151, 16, true);
            WriteLiteral("<main>\r\n    <h1>");
            EndContext();
            BeginContext(168, 17, false);
#line 7 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
   Write(Model.UsuarioNome);

#line default
#line hidden
            EndContext();
            BeginContext(185, 32, true);
            WriteLiteral(", Seus Orçamentos</h1>\r\n    <h2>");
            EndContext();
            BeginContext(218, 14, false);
#line 8 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
   Write(ViewData["H2"]);

#line default
#line hidden
            EndContext();
            BeginContext(232, 328, true);
            WriteLiteral(@"</h2>
    <table>
        <thead>
            <tr>
                <th>Data Solicitado</th>
                <th>DataEvento</th>
                <th>Evento</th>
                <th>Pacote Servicos</th>
                <th>Preço</th>
                <th>Status</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 21 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
             foreach( var orcamento in Model.Orcamentos ) {

#line default
#line hidden
            BeginContext(621, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(668, 25, false);
#line 23 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
                   Write(orcamento.DataDoOrcamento);

#line default
#line hidden
            EndContext();
            BeginContext(693, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(725, 22, false);
#line 24 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
                   Write(orcamento.DataDoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(747, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(779, 21, false);
#line 25 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
                   Write(orcamento.Evento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(800, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(832, 29, false);
#line 26 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
                   Write(orcamento.PacoteServicos.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(861, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(893, 20, false);
#line 27 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
                   Write(orcamento.PrecoTotal);

#line default
#line hidden
            EndContext();
            BeginContext(913, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 28 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
                     if(@orcamento.Status ==0){

#line default
#line hidden
            BeginContext(969, 43, true);
            WriteLiteral("                        <td>PENDENTE</td>\r\n");
            EndContext();
#line 30 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
                    }
                    else if(@orcamento.Status ==1){

#line default
#line hidden
            BeginContext(1088, 43, true);
            WriteLiteral("                        <td>APROVADO</td>\r\n");
            EndContext();
#line 33 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
                    }
                    else if(@orcamento.Status ==2){

#line default
#line hidden
            BeginContext(1207, 44, true);
            WriteLiteral("                        <td>REPROVADO</td>\r\n");
            EndContext();
#line 36 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
                    }

#line default
#line hidden
            BeginContext(1274, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 38 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
            }

#line default
#line hidden
            BeginContext(1312, 41, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTop.ViewModels.HistoricoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
