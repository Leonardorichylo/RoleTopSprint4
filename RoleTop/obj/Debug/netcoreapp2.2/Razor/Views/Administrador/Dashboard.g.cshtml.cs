#pragma checksum "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a4ffabff8f708dc17a109710aedb28a4739ca95"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a4ffabff8f708dc17a109710aedb28a4739ca95", @"/Views/Administrador/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8fc0cfda6b2bb54f88e5d7a55c241985d2df4ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTop.ViewModels.DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 283, true);
            WriteLiteral(@"    <main>
        <h2>Dashboard</h2>
        <section id=""status-orcamentos"">
            <h3>Status dos Orçamentos</h3>
            <div id=""painel"">
                <div class=""box-status-orcamentos aprovados"">
                    <h4>Aprovados</h4>
                    <p>");
            EndContext();
            BeginContext(330, 25, false);
#line 9 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
                  Write(Model.OrcamentosAprovados);

#line default
#line hidden
            EndContext();
            BeginContext(355, 156, true);
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"box-status-orcamentos pendentes\">\r\n                    <h4>Pendentes</h4>\r\n                    <p>");
            EndContext();
            BeginContext(512, 25, false);
#line 13 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
                  Write(Model.OrcamentosPendentes);

#line default
#line hidden
            EndContext();
            BeginContext(537, 158, true);
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"box-status-orcamentos reprovados\">\r\n                    <h4>Reprovados</h4>\r\n                    <p>");
            EndContext();
            BeginContext(696, 26, false);
#line 17 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
                  Write(Model.OrcamentosReprovados);

#line default
#line hidden
            EndContext();
            BeginContext(722, 1006, true);
            WriteLiteral(@"</p>
                </div>
            </div>
        </section>

        <section id=""lista-orcamentos"">
            <h3>Lista de orçamentos</h3>
            <table>
                <thead>
                    <tr>
                        <th rowspan=""2"">Nome</th>
                        <th rowspan=""2"">Endereço</th>
                        <th colspan=""5"">Orçamento</th>
                        <th colspan=""2"" rowspan=""2"">Aprovar</th>
                    </tr>
                    <tr>
                        <th>Data Evento</th>
                        <th>Evento</th>
                        <th>PacoteServicos</th> 
                        <th>TipoEvento</th>
                        <th>FormaPagamento</th>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <td colspan=""9"">
                            Pedidos atualizados em ");
            EndContext();
            BeginContext(1729, 12, false);
#line 45 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
                                              Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(1741, 111, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                </tfoot>\r\n                <tbody>\r\n");
            EndContext();
#line 50 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
                         foreach (var orcamento in Model.Orcamentos)
                        {

#line default
#line hidden
            BeginContext(1949, 61, true);
            WriteLiteral("                        <tr>\r\n                        <td><p>");
            EndContext();
            BeginContext(2011, 22, false);
#line 53 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
                          Write(orcamento.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2033, 42, true);
            WriteLiteral("</p></td>\r\n                        <td><p>");
            EndContext();
            BeginContext(2076, 26, false);
#line 54 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
                          Write(orcamento.Cliente.Endereco);

#line default
#line hidden
            EndContext();
            BeginContext(2102, 42, true);
            WriteLiteral("</p></td>\r\n                        <td><p>");
            EndContext();
            BeginContext(2145, 22, false);
#line 55 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
                          Write(orcamento.DataDoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(2167, 42, true);
            WriteLiteral("</p></td>\r\n                        <td><p>");
            EndContext();
            BeginContext(2210, 21, false);
#line 56 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
                          Write(orcamento.Evento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2231, 42, true);
            WriteLiteral("</p></td>\r\n                        <td><p>");
            EndContext();
            BeginContext(2274, 29, false);
#line 57 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
                          Write(orcamento.PacoteServicos.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2303, 42, true);
            WriteLiteral("</p></td>\r\n                        <td><p>");
            EndContext();
            BeginContext(2346, 20, false);
#line 58 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
                          Write(orcamento.TipoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(2366, 42, true);
            WriteLiteral("</p></td>\r\n                        <td><p>");
            EndContext();
            BeginContext(2409, 24, false);
#line 59 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
                          Write(orcamento.FormaPagamento);

#line default
#line hidden
            EndContext();
            BeginContext(2433, 41, true);
            WriteLiteral("</p></td>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2474, "\'", 2542, 1);
#line 60 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2481, Url.Action("Aprovar", "Orcamento", new {id = @orcamento.Id}), 2481, 61, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2543, 70, true);
            WriteLiteral("><i class=\"fas fa-check\"></i></a></td>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2613, "\'", 2682, 1);
#line 61 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2620, Url.Action("Reprovar", "Orcamento", new {id = @orcamento.Id}), 2620, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2683, 71, true);
            WriteLiteral("><i class=\"fas fa-times\"></i></a></td>\r\n                        </tr>\r\n");
            EndContext();
#line 63 "C:\Users\40349113874\Documents\RoleTopSprint4\RoleTop\Views\Administrador\Dashboard.cshtml"
                        }

#line default
#line hidden
            BeginContext(2781, 81, true);
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
