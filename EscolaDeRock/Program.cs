using System;
using System.Collections.Generic;
using EscolaDeRock.Models;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock
{
    enum FormacaoEnum : int
    {
        TRIO = 3,
        QUARTETO
    };

    enum InstrumentosEnum : int
    {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        TECLADO,
        TAMBORES,
        VIOLÃO
    };

    enum CategoriaEnum : int
    {
        HARMONIA,
        PERCURSSÃO,
        MELODIA
    };

    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = false;
            string[] itensMenuPrincipal = Enum.GetNames(typeof(FormacaoEnum));
            string[] itensMenuCtegoria = Enum.GetNames(typeof(CategoriaEnum));

            var opcoesFormacao = new List<string>()
            {
                "   - 0                 ",
                "   - 1              "
            };

            int opcoesFormacaoSelecionada = 0;
            string menuBar = "================================";

            do
            {
                bool formacaoEscolhida = false;
                do
                {
                    #region Area do Menu
                    Console.Clear();
                    Console.WriteLine(menuBar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("      Seja bem-vind@     ");
                    Console.WriteLine("   Escolha uma formação  ");
                    Console.ResetColor();
                    Console.WriteLine(menuBar);

                    for (int i = 0; i < opcoesFormacao.Count; i++)
                    {
                        string titulo = itensMenuPrincipal[i];
                        if (opcoesFormacaoSelecionada == i)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(opcoesFormacao[opcoesFormacaoSelecionada].Replace("-", ">").Replace(i.ToString(), titulo));
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine(opcoesFormacao[i].Replace(i.ToString(), titulo));
                        }
                    }
                    var key = Console.ReadKey(true).Key;

                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                            opcoesFormacaoSelecionada = opcoesFormacaoSelecionada == 0 ? opcoesFormacaoSelecionada : --opcoesFormacaoSelecionada;
                            break;
                        case ConsoleKey.DownArrow:
                            opcoesFormacaoSelecionada = opcoesFormacaoSelecionada == opcoesFormacao.Count - 1 ? opcoesFormacaoSelecionada : ++opcoesFormacaoSelecionada;
                            break;
                        case ConsoleKey.Enter:
                            formacaoEscolhida = true;
                            break;

                    }
                    #endregion
                } while (formacaoEscolhida);
            bool bandaCompleta = false;
            int vagas = 0;

            #region Adiciona os intrumentos a formação escolhida
            #endregion
            switch (opcoesFormacaoSelecionada)
            {
                #region Cadastro de Instrumentos para trios
                #endregion
                case 0:
                    vagas = 2;
                    do
                    {
                        ExibirMenuDeInstrumentos();

                        Console.Write($"Digite o código do instrumento de harmonia:");
                        int codigo = int.Parse(Console.ReadLine());
                        var instrumento = Deposito.Instrumentos[codigo];
                        Type interfaceEncontrada = instrumento.GetType().GetInterface("IPercurssao");

                        if (interfaceEncontrada != null)
                        {
                            vagas--;
                            ColocarNaBanda((IPercurssao)instrumento);
                        }
                        else
                        {
                            System.Console.WriteLine("O instrumento selecionado não é de percurssão");
                            continue;
                        }

                        if (vagas == 0)
                        {
                            bandaCompleta = true;
                        }
                    } while (!bandaCompleta);
                    System.Console.WriteLine("Sua banda está completa!");
                    Console.ReadLine();
                    break;
                
            }
            } while (!querSair);
        }
        #region Adiciona instrumentos na banda.
        public static bool ColocarNaBanda(IHarmonia harmonia)
        {
            harmonia.TocarAcordes();
            System.Console.WriteLine(harmonia.GetType().BaseType + " foi incluído");
            return true;
        }

        public static bool ColocarNaBanda(IPercurssao percussao)
        {
            percussao.ManterORitmo();
            System.Console.WriteLine(percussao.GetType().BaseType + " foi incluído");
            return true;
        }

        public static bool ColocarNaBanda(IMelodia melodia)
        {
            melodia.TocarSolo();
            System.Console.WriteLine(melodia.GetType().BaseType + " foi incluído");
            return true;
        }
        #endregion

        public static void DestacarOpcao(string opcao)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine(opcao);
            Console.ResetColor();
        }

        public static void ExibirMenuDeInstrumentos()
        {
            var instrumentos = Enum.GetNames(typeof(InstrumentosEnum));
            int codigo = 1;
            string menuInstrumentoBorda = "##############################";

            System.Console.WriteLine(menuInstrumentoBorda);
            System.Console.WriteLine("#                            #");
            System.Console.WriteLine("#        Instrumentos        #");
            System.Console.WriteLine("#                            #");
            System.Console.WriteLine(menuInstrumentoBorda);

            foreach (var instrumento in instrumentos)
            {
                System.Console.WriteLine($"  {codigo++}.{TratarTituloMenu(instrumento)}");
            }

            System.Console.WriteLine(menuInstrumentoBorda);
        }

        public static void ExibirMenuDeCategorias()
        {
            var categorias = Enum.GetNames(typeof(CategoriaEnum));
            int codigo = 1;
            string menuInstrumentoBorda = "##############################";
            System.Console.WriteLine(menuInstrumentoBorda);
            System.Console.WriteLine("#          Categorias        #");

            foreach (var categoria in categorias)
            {

                System.Console.WriteLine($"  {codigo++}.{TratarTituloMenu(categoria)}");
            }

            System.Console.WriteLine(menuInstrumentoBorda);

        }

        public static string TratarTituloMenu(string titulo)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titulo.Replace("_", " ").ToLower());
        }
        
    }
}