#pragma checksum "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "712b310c5986a29abdbdd5395f35f453f2734fde"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"712b310c5986a29abdbdd5395f35f453f2734fde", @"/Views/Cliente/Historico.cshtml")]
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
            WriteLiteral("<main>\r\n    <h2>");
            EndContext();
            BeginContext(168, 14, false);
#line 7 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
   Write(ViewData["H2"]);

#line default
#line hidden
            EndContext();
            BeginContext(182, 332, true);
            WriteLiteral(@"</h2>
    <table>
        <thead>
            <tr>
                <th>Data Solicitado</th>
                <th>Data do Evento</th>
                <th>Evento</th>
                <th>Pacote Servicos</th>
                <th>Preço</th>
                <th>Status</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 20 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
             foreach( var orcamento in Model.Orcamentos) {

#line default
#line hidden
            BeginContext(574, 49, true);
            WriteLiteral("                <tr>\r\n                    <td><p>");
            EndContext();
            BeginContext(624, 25, false);
#line 22 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
                      Write(orcamento.DataDoOrcamento);

#line default
#line hidden
            EndContext();
            BeginContext(649, 38, true);
            WriteLiteral("</p></td>\r\n                    <td><p>");
            EndContext();
            BeginContext(688, 22, false);
#line 23 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
                      Write(orcamento.DataDoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(710, 38, true);
            WriteLiteral("</p></td>\r\n                    <td><p>");
            EndContext();
            BeginContext(749, 21, false);
#line 24 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
                      Write(orcamento.Evento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(770, 38, true);
            WriteLiteral("</p></td>\r\n                    <td><p>");
            EndContext();
            BeginContext(809, 29, false);
#line 25 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
                      Write(orcamento.PacoteServicos.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(838, 38, true);
            WriteLiteral("</p></td>\r\n                    <td><p>");
            EndContext();
            BeginContext(877, 20, false);
#line 26 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
                      Write(orcamento.PrecoTotal);

#line default
#line hidden
            EndContext();
            BeginContext(897, 11, true);
            WriteLiteral("</p></td>\r\n");
            EndContext();
#line 27 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
                     if(@orcamento.Status ==0){

#line default
#line hidden
            BeginContext(957, 50, true);
            WriteLiteral("                        <td><p>PENDENTE</p></td>\r\n");
            EndContext();
#line 29 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
                    }
                    else if(@orcamento.Status ==1){

#line default
#line hidden
            BeginContext(1083, 50, true);
            WriteLiteral("                        <td><p>APROVADO</p></td>\r\n");
            EndContext();
#line 32 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
                    }
                    else if(@orcamento.Status ==2){

#line default
#line hidden
            BeginContext(1209, 51, true);
            WriteLiteral("                        <td><p>REPROVADO</p></td>\r\n");
            EndContext();
#line 35 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
                    }

#line default
#line hidden
            BeginContext(1283, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 37 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Cliente\Historico.cshtml"
            }

#line default
#line hidden
            BeginContext(1321, 41, true);
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
