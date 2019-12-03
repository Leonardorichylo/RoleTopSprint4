#pragma checksum "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "253c5aede1a37ecb01e917c2a63d27a6c39ddfc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Dashboard), @"mvc.1.0.view", @"/Views/Administrador/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Dashboard.cshtml", typeof(AspNetCore.Views_Administrador_Dashboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"253c5aede1a37ecb01e917c2a63d27a6c39ddfc7", @"/Views/Administrador/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8fc0cfda6b2bb54f88e5d7a55c241985d2df4ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTop.ViewModels.DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 285, true);
            WriteLiteral(@"    <main>
        <h2>Dashboard</h2>

        <section id=""status-orcamentos"">
            <h3>Status dos Orçamentos</h3>
            <div id=""painel"">
                <div class=""box-status-orcamentos aprovados"">
                    <h4>Aprovados</h4>
                    <p>");
            EndContext();
            BeginContext(332, 25, false);
#line 10 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
                  Write(Model.OrcamentosAprovados);

#line default
#line hidden
            EndContext();
            BeginContext(357, 156, true);
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"box-status-orcamentos pendentes\">\r\n                    <h4>Pendentes</h4>\r\n                    <p>");
            EndContext();
            BeginContext(514, 25, false);
#line 14 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
                  Write(Model.OrcamentosPendentes);

#line default
#line hidden
            EndContext();
            BeginContext(539, 157, true);
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"box-status-orcamentos reprovados\">\r\n                    <h4>Recusados</h4>\r\n                    <p>");
            EndContext();
            BeginContext(697, 26, false);
#line 18 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
                  Write(Model.OrcamentosReprovados);

#line default
#line hidden
            EndContext();
            BeginContext(723, 887, true);
            WriteLiteral(@"</p>
                </div>
            </div>
        </section>

        <section id=""lista-orcamentos"">
            <h3>Lista de Orçamentos</h3>
            <table>
                <thead>
                    <tr>
                        <th rowspan=""2"">Nome</th>
                        <th rowspan=""2"">Endereço</th>
                        <th colspan=""2"">Pedido</th>
                        <th colspan=""2"" rowspan=""2"">Aprovar</th>
                    </tr>
                    <tr>
                        <th><i class=""fas fa-calendar-week""></i></th>
                        <th>Evento</th>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <td colspan=""6"">
                            <p>Pedidos atualizados em ");
            EndContext();
            BeginContext(1611, 12, false);
#line 43 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
                                                 Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(1623, 115, true);
            WriteLiteral("</p>\r\n                        </td>\r\n                    </tr>\r\n                </tfoot>\r\n                <tbody>\r\n");
            EndContext();
#line 48 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
                         foreach (var orcamento in Model.Orcamentos)
                        {

#line default
#line hidden
            BeginContext(1835, 58, true);
            WriteLiteral("                        <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1894, 22, false);
#line 51 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
                       Write(orcamento.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1916, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1952, 26, false);
#line 52 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
                       Write(orcamento.Cliente.Endereco);

#line default
#line hidden
            EndContext();
            BeginContext(1978, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2014, 21, false);
#line 53 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
                       Write(orcamento.Evento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2035, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2071, 29, false);
#line 54 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
                       Write(orcamento.PacoteServicos.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2100, 37, true);
            WriteLiteral("</td>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2137, "\'", 2205, 1);
#line 55 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2144, Url.Action("Aprovar", "Orcamento", new {id = @orcamento.Id}), 2144, 61, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2206, 70, true);
            WriteLiteral("><i class=\"fas fa-check\"></i></a></td>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2276, "\'", 2345, 1);
#line 56 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2283, Url.Action("Reprovar", "Orcamento", new {id = @orcamento.Id}), 2283, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2346, 71, true);
            WriteLiteral("><i class=\"fas fa-times\"></i></a></td>\r\n                        </tr>\r\n");
            EndContext();
#line 58 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
                        }

#line default
#line hidden
            BeginContext(2444, 81, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </section>\r\n\r\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTop.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
