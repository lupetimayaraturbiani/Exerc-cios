#pragma checksum "C:\Users\49393984808\Documents\Exercícios\RoleTopMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f9f6b1b18e8cc7972499c305d0fc00d188bc413"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f9f6b1b18e8cc7972499c305d0fc00d188bc413", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5769cfbe4dda628aabf19144c89567913a2623fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2337, true);
            WriteLiteral(@"
    <main>

        <section id=""Banner"">
            <img src=""img/banner.png"" />
        </section>

        <section id=""SobreoEspaço"">
            <div class=""section-container"">
                <br />
                <h2>Sobre o Espaço</h2>
                <br />
                <div class=""flex-group-sobre-o-espaço"">
                    
                            <p>Nosso espaço conta com uma infraestrutura
                            <br />
                            acessível para todos os tipos de pessoas,
                            <br />
                            além de possuir um espaço confortável e privado
                            <br />
                            de 150X40 metros. Cadastre - se no nosso site e 
                            <br />
                            e reserve uma data conosco!</p>
                
                            <section class=""icones"">
                                <img src=""/img/icones.png""/>
                            </section>
           ");
            WriteLiteral(@"     </div>


        </section>
        </div>

        <section id=""evento-da-semana"">
            <ul>
                <li>Evento da Semana</li>
            </ul>
            <h2>Casamento Romeu e Julieta</h2>
            <img src=""img/goiabadaequeijo.jpg"">
            <p>Neste ilustre domingo, dia 14/09 ás 13hrs,
                <br />
                Romeu e Julieta iram finalmente celebrar
                <br />
                sua união. </p>
                <br />
        </section>

        <section id=""Local"">
            <iframe
                src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3657.891970953056!2d-46.648477085022684!3d-23.536387584695266!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce5843d981c42f%3A0xaa6c15f8c7e2c130!2sAlameda%20Bar%C3%A3o%20de%20Limeira%2C%20539!5e0!3m2!1spt-BR!2sbr!4v1567451014055!5m2!1spt-BR!2sbr""
                width=""100%"" height=""450"" frameborder=""0"" style=""border:0;"" allowfullscreen=""""></iframe>
        </section>

    </main>

    <sectio");
            WriteLiteral(@"n id=""rodape"">
        <footer>
            <address>
                <br />
                Avenida de Limeira, 539 - Campos Elíseos - SP
                <br />
                11 1234 6789
            </address>
        </footer>
        <a href=""#"">Inicio da página</a>
    </section>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
