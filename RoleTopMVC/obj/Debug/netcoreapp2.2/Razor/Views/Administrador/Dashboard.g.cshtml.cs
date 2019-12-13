#pragma checksum "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f33a4f9ce975ceb24fa23341263546001170a58d"
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
#line 1 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f33a4f9ce975ceb24fa23341263546001170a58d", @"/Views/Administrador/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5769cfbe4dda628aabf19144c89567913a2623fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 267, true);
            WriteLiteral(@"    <main>
        <h2>Dashboard</h2>
        <section id=""status-eventos"">
            <h3>Status dos Eventos</h3>
            <div id=""painel"">
                <div class=""box-status-eventos aprovados"">
                    <h4>Aprovados</h4>
                    <p>");
            EndContext();
            BeginContext(316, 22, false);
#line 9 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                  Write(Model.EventosAprovados);

#line default
#line hidden
            EndContext();
            BeginContext(338, 149, true);
            WriteLiteral("</p>\n                </div>\n                <div class=\"box-status-eventos pendentes\">\n                    <h4>Pendentes</h4>\n                    <p>");
            EndContext();
            BeginContext(488, 22, false);
#line 13 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                  Write(Model.EventosPendentes);

#line default
#line hidden
            EndContext();
            BeginContext(510, 151, true);
            WriteLiteral("</p>\n                </div>\n                <div class=\"box-status-eventos reprovados\">\n                    <h4>Reprovados</h4>\n                    <p>");
            EndContext();
            BeginContext(662, 23, false);
#line 17 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                  Write(Model.EventosReprovados);

#line default
#line hidden
            EndContext();
            BeginContext(685, 728, true);
            WriteLiteral(@"</p>
                </div>
            </div>
        </section>

        <section id=""lista-eventos"">
            <h3>Lista de eventos</h3>
            <table>
                <thead>
                    <tr>
                        <th rowspan=""2"">Nome Evento</th>
                        <th rowspan=""2"">Data Evento</th>
                        <th rowspan=""2"">Horario</th>
                        <th >Tipo de Evento</th>
                        <th >Serviço Adicional</th>
                        <th  rowspan=""7"">Aprovar</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <td colspan=""6"">
                            <p>Eventos atualizados em ");
            EndContext();
            BeginContext(1414, 12, false);
#line 38 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                                                 Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(1426, 110, true);
            WriteLiteral("</p>\n                        </td>\n                    </tr>\n                </tfoot>\n                <tbody>\n");
            EndContext();
#line 43 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                     foreach(var evento in Model.Eventos )
                    {

#line default
#line hidden
            BeginContext(1617, 61, true);
            WriteLiteral("                        <tr>\n                            <td>");
            EndContext();
            BeginContext(1679, 17, false);
#line 46 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                           Write(evento.NomeEvento);

#line default
#line hidden
            EndContext();
            BeginContext(1696, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1735, 17, false);
#line 47 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                           Write(evento.DataEvento);

#line default
#line hidden
            EndContext();
            BeginContext(1752, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1791, 14, false);
#line 48 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                           Write(evento.Horario);

#line default
#line hidden
            EndContext();
            BeginContext(1805, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1844, 23, false);
#line 49 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                           Write(evento.TiposEvento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1867, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1906, 30, false);
#line 50 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                           Write(evento.ServicosAdicionais.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1936, 40, true);
            WriteLiteral("</td>\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1976, "\'", 2039, 1);
#line 51 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 1983, Url.Action("Aprovar", "Usuario", new {id = @evento.Id}), 1983, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2040, 73, true);
            WriteLiteral("><i class=\"fas fa-check\"></i></a></td>\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2113, "\'", 2177, 1);
#line 52 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2120, Url.Action("Reprovar", "Usuario", new {id = @evento.Id}), 2120, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2178, 69, true);
            WriteLiteral("><i class=\"fas fa-times\"></i></a></td>\n                        </tr>\n");
            EndContext();
#line 54 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                    }

#line default
#line hidden
            BeginContext(2269, 77, true);
            WriteLiteral("                </tbody>\n            </table>\n        </section>\n\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
