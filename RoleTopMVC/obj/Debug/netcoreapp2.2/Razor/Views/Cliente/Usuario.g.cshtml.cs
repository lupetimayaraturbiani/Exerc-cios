#pragma checksum "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "464cf2ca297fb74d378feaba0b3177d3c326cec2"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"464cf2ca297fb74d378feaba0b3177d3c326cec2", @"/Views/Cliente/Usuario.cshtml")]
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
    ViewData["H2"] = "Página do Usuário";

#line default
#line hidden
            BeginContext(143, 20, true);
            WriteLiteral("<main>\r\n        <h2>");
            EndContext();
            BeginContext(164, 17, false);
#line 7 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
       Write(Model.NomeCliente);

#line default
#line hidden
            EndContext();
            BeginContext(181, 313, true);
            WriteLiteral(@"</h2>

        <img src=""img/icone usuário.png"" id=""icone-usuario"" />

        <section class=""topicos"">
            <p>Minha Conta</p>
            <br />
            <br />
            <br />
            <br />
                <h2>Cadastre seu evento</h2>
        <section id=""cadastro"">
            ");
            EndContext();
            BeginContext(494, 2472, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "464cf2ca297fb74d378feaba0b3177d3c326cec24987", async() => {
                BeginContext(558, 1174, true);
                WriteLiteral(@"
                <div>
                    <label for=""nome"">Nome do Evento</label>
                    <br />
                    <input id=""nome"" type=""nome"" maxlength=""40"" minlength=""10"" name=""email"" name=""nome"" />
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
                    <input id=""pagamento"" type=""text"" maxlength=""5"" minlength=""5"" name=""pagamento""/>
                </div>

                <label for=");
                WriteLiteral("\"categoria\">Serviços Adicionais</label>\r\n                <br />\r\n                <select id=\'select\' name=\"servicos_adicionais\">\r\n                    ");
                EndContext();
                BeginContext(1732, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "464cf2ca297fb74d378feaba0b3177d3c326cec26640", async() => {
                    BeginContext(1768, 9, true);
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
                BeginContext(1786, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 48 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                     foreach (var servicosAdicionais in Model.ServicosAdicionais)
                    {

#line default
#line hidden
                BeginContext(1894, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1918, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "464cf2ca297fb74d378feaba0b3177d3c326cec29122", async() => {
                    BeginContext(1958, 23, false);
#line 50 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                                                          Write(servicosAdicionais.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(1981, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(1987, 24, false);
#line 50 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                                                                                       Write(servicosAdicionais.Preco);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 50 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
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
                BeginContext(2020, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 51 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                    }

#line default
#line hidden
                BeginContext(2045, 213, true);
                WriteLiteral("\r\n                </select>\r\n                <br />\r\n                <label for=\"categoria\">Categoria</label>\r\n                <br />\r\n                <select id=\"select\" name=\"tipos_evento\">\r\n                    ");
                EndContext();
                BeginContext(2258, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "464cf2ca297fb74d378feaba0b3177d3c326cec212154", async() => {
                    BeginContext(2294, 9, true);
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
                BeginContext(2312, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 59 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                     foreach (var tipos_evento in Model.TiposEvento)
                    {

#line default
#line hidden
                BeginContext(2407, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(2431, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "464cf2ca297fb74d378feaba0b3177d3c326cec214623", async() => {
                    BeginContext(2465, 17, false);
#line 61 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                                                    Write(tipos_evento.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(2482, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(2488, 18, false);
#line 61 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                                                                           Write(tipos_evento.Preco);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 61 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                          WriteLiteral(tipos_evento.Nome);

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
                BeginContext(2515, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 62 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                    }

#line default
#line hidden
                BeginContext(2540, 419, true);
                WriteLiteral(@"                </select>
                <br />
                <label for=""descricao""> Descrição do Evento</label>
                <br />
                <textarea name=""descricao"" id=""descricao"" cols=""8"" rows=""6"" name=""descricao""></textarea>
                    placeholder=""Descrição do evento""></textarea>
                <br />
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
#line 19 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
AddHtmlAttributeValue("", 522, Url.Action("Registrar", "Evento"), 522, 34, false);

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
            BeginContext(2966, 99, true);
            WriteLiteral("\r\n        </section>\r\n\r\n        <br />\r\n        <br />\r\n\r\n        <p>Meus Eventos</p>\r\n        <h2>");
            EndContext();
            BeginContext(3066, 14, false);
#line 78 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
       Write(ViewData["H2"]);

#line default
#line hidden
            EndContext();
            BeginContext(3080, 376, true);
            WriteLiteral(@"</h2>
    <table>
        <thead>
            <tr>
                <th>Nome</th>
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
#line 92 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
             foreach( var evento in Model.Eventos ) {

#line default
#line hidden
            BeginContext(3511, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(3558, 11, false);
#line 94 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(3569, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3601, 17, false);
#line 95 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.DataEvento);

#line default
#line hidden
            EndContext();
            BeginContext(3618, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3650, 14, false);
#line 96 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.Horario);

#line default
#line hidden
            EndContext();
            BeginContext(3664, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3696, 23, false);
#line 97 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.TiposEvento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(3719, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3751, 16, false);
#line 98 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(3767, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3799, 30, false);
#line 99 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.ServicosAdicionais.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(3829, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3861, 17, false);
#line 100 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
                   Write(evento.PrecoTotal);

#line default
#line hidden
            EndContext();
            BeginContext(3878, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 102 "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Cliente\Usuario.cshtml"
            }

#line default
#line hidden
            BeginContext(3923, 113, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n            <p>Cancelamentos</p>\r\n            \r\n        </section>\r\n    </main>");
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
