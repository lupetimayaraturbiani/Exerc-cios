#pragma checksum "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc5e7001db0451677813241143aeb6e2fcee8c45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Usuario), @"mvc.1.0.view", @"/Views/Cliente/Usuario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Usuario.cshtml", typeof(AspNetCore.Views_Cliente_Usuario))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc5e7001db0451677813241143aeb6e2fcee8c45", @"/Views/Cliente/Usuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5769cfbe4dda628aabf19144c89567913a2623fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Usuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.UsuarioViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
  
    ViewData["Title"] = "Usuario - RoleTop";

#line default
#line hidden
            BeginContext(96, 157, true);
            WriteLiteral("<main>\n    <br/>\n    <h2>Minha Conta</h2>\n\n        <img src=\"/img/icone usuário.png\" id=\"icone-usuario\" />\n\n        <section class=\"topicos\">\n            <p>");
            EndContext();
            BeginContext(254, 17, false);
#line 12 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
          Write(Model.NomeCliente);

#line default
#line hidden
            EndContext();
            BeginContext(271, 20, true);
            WriteLiteral("</p>\n            <p>");
            EndContext();
            BeginContext(292, 19, false);
#line 13 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
          Write(Model.Cliente.Email);

#line default
#line hidden
            EndContext();
            BeginContext(311, 20, true);
            WriteLiteral("</p>\n            <p>");
            EndContext();
            BeginContext(332, 22, false);
#line 14 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
          Write(Model.Cliente.Telefone);

#line default
#line hidden
            EndContext();
            BeginContext(354, 96, true);
            WriteLiteral("</p>\n    <br/>\n        <h2>Cadastre seu Evento</h2>\n        <section id=\"cadastro\">\n            ");
            EndContext();
            BeginContext(450, 3280, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc5e7001db0451677813241143aeb6e2fcee8c455586", async() => {
                BeginContext(515, 181, true);
                WriteLiteral("\n                \n                <div>\n                    <label for=\"nome\">Nome do Contratante</label>\n                    <br />\n                    <input id=\"nome\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 696, "\"", 723, 1);
#line 23 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
WriteAttributeValue("", 704, Model.Cliente.Nome, 704, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(724, 205, true);
                WriteLiteral(" name=\"nome\"/>\n                </div>\n\n                <div>\n                    <label for=\"email\">Email do Contratante</label>\n                    <br />\n                    <input id=\"email\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 929, "\"", 957, 1);
#line 29 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
WriteAttributeValue("", 937, Model.Cliente.Email, 937, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(958, 215, true);
                WriteLiteral(" name=\"email\"/>\n                </div>\n\n                <div>\n                    <label for=\"telefone\">Telefone do Contratante</label>\n                    <br />\n                    <input id=\"telefone\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1173, "\"", 1204, 1);
#line 35 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
WriteAttributeValue("", 1181, Model.Cliente.Telefone, 1181, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1205, 1219, true);
                WriteLiteral(@" name=""telefone""/>
                </div>

                <div>
                    <label for=""nome"">Nome do Evento</label>
                    <br />
                    <input id=""nome"" type=""text"" maxlength=""20"" minlength=""3""  name=""nome_evento""/>
                </div>

                <div>
                    <label for=""data do evento"">Data do Evento</label>
                    <br />
                    <input id=""data do evento"" type=""date"" maxlength=""10"" minlength=""10"" name=""data_evento""/>
                </div>

                <div>
                    <label for=""hora"">Horário do Evento</label>
                    <br />
                    <input id=""hora"" type=""time"" maxlength=""5"" minlength=""5"" name=""horario"" />
                </div>

                <div>
                    <label for=""pagamento"">Forma de Pagamento</label>
                    <br />
                    <input id=""pagamento"" type=""text""  minlength=""6"" name=""pagamento""/>
                </div>

                <div>
        ");
                WriteLiteral("            <label for=\"servicosAdicionais\">Serviços Adicionais</label>\n                    <br />\n                <select id=\"servicosAdicionais\" name=\"servicosAdicionais\" >\n                    ");
                EndContext();
                BeginContext(2424, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc5e7001db0451677813241143aeb6e2fcee8c459195", async() => {
                    BeginContext(2460, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2478, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 67 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                     foreach (var servicosAdicionais in Model.ServicosAdicionais)
                    {

#line default
#line hidden
                BeginContext(2583, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(2607, 128, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc5e7001db0451677813241143aeb6e2fcee8c4511673", async() => {
                    BeginContext(2647, 23, false);
#line 69 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                                                          Write(servicosAdicionais.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(2670, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(2676, 24, false);
#line 69 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                                                                                       Write(servicosAdicionais.Preco);

#line default
#line hidden
                    EndContext();
                    BeginContext(2700, 26, true);
                    WriteLiteral("\n\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 69 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                          WriteLiteral(servicosAdicionais.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2735, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 72 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                    }

#line default
#line hidden
                BeginContext(2758, 266, true);
                WriteLiteral(@"
                </select>
                </div>
                
                <div>
                    <label for=""tiposEvento"">Tipo de Evento</label>
                    <br />
                <select id=""tiposEvento"" name=""tiposEvento"" >
                    ");
                EndContext();
                BeginContext(3024, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc5e7001db0451677813241143aeb6e2fcee8c4514898", async() => {
                    BeginContext(3060, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3078, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 82 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                     foreach (var tiposEvento in Model.TiposEvento)
                    {

#line default
#line hidden
                BeginContext(3169, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(3193, 107, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc5e7001db0451677813241143aeb6e2fcee8c4517363", async() => {
                    BeginContext(3226, 16, false);
#line 84 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                                                   Write(tiposEvento.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(3242, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(3248, 17, false);
#line 84 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                                                                         Write(tiposEvento.Preco);

#line default
#line hidden
                    EndContext();
                    BeginContext(3265, 26, true);
                    WriteLiteral("\n\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 84 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                          WriteLiteral(tiposEvento.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3300, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 87 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                    }

#line default
#line hidden
                BeginContext(3323, 400, true);
                WriteLiteral(@"                </select>
                </div>

                <div>
                    <label for=""descricao""> Descrição do Evento</label>
                    <br />
                    <textarea placeholder=""Descrição do evento"" cols=""50"" rows=""5"" name=""descricao"" id=""descricao"" ></textarea>
                </div>

                <input type=""submit"" value=""Cadastrar evento"" />
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 18 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
AddHtmlAttributeValue("", 478, Url.Action("Registrar", "Usuario"), 478, 35, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3730, 448, true);
            WriteLiteral(@"
        </section>

        <br />
        <br />

        <h2>Meus Eventos</h2>
    <table>
        <thead>
            <tr>
                <th>Nome do Evento</th>
                <th>Data do Evento</th>
                <th>Horário</th>
                <th>Tipo de Evento</th>
                <th>Descrição</th>
                <th>Serviços Adicionais</th>
                <th>Preço Total</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 118 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
             foreach( var evento in Model.Eventos ) {

#line default
#line hidden
            BeginContext(4232, 45, true);
            WriteLiteral("                <tr>\n                    <td>");
            EndContext();
            BeginContext(4278, 17, false);
#line 120 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.NomeEvento);

#line default
#line hidden
            EndContext();
            BeginContext(4295, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(4326, 17, false);
#line 121 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.DataEvento);

#line default
#line hidden
            EndContext();
            BeginContext(4343, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(4374, 14, false);
#line 122 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.Horario);

#line default
#line hidden
            EndContext();
            BeginContext(4388, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(4419, 23, false);
#line 123 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.TiposEvento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(4442, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(4473, 16, false);
#line 124 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(4489, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(4520, 30, false);
#line 125 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.ServicosAdicionais.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(4550, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(4581, 17, false);
#line 126 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.PrecoTotal);

#line default
#line hidden
            EndContext();
            BeginContext(4598, 28, true);
            WriteLiteral("</td>\n                </tr>\n");
            EndContext();
#line 128 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
            }

#line default
#line hidden
            BeginContext(4640, 60, true);
            WriteLiteral("        </tbody>\n    </table>\n        </section>\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.UsuarioViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
