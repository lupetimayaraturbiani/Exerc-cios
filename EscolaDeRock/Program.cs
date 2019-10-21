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

    enum InstumentosEnum : int
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
                        

                        Console.Write($"Digite o código do instrumento de harmonia");
                    } while (true);
                
            }
            } while (!querSair);
        }

        
    }
}