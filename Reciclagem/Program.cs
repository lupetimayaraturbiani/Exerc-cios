using System;
using System.Collections.Generic;
using Reciclagem.Interfaces;
using Reciclagem.Models;

namespace Reciclagem
{
    enum LixosEnum : int
    {
        DESODORANTE,
        FRASCOPERFUME,
        GARRAFAPET,
        GUARDANAPO,
        LATINHA,
        PAPELÃO,
        PILHA,
        SACOCAFÉ
    };

    enum CategoriaEnum : int
    {
        DESCARTEESPECIAL,
        METAL,
        ORGANICO,
        PAPEL,
        PLÁSTICO,
        VIDRO
    };
    class Program
    {
        static void Main(string[] args)
        {
            string[] itensMenuPrincipal = Enum.GetNames(typeof(LixosEnum));

            

            

                ExibirMenuDeLixos();

                System.Console.WriteLine("Digite o número correspondente ao lixo: ");
                int codigo = int.Parse(Console.ReadLine());

            
        }

        public static void ExibirMenuDeLixos()
        {
            var lixos = Enum.GetNames(typeof(LixosEnum));
            int codigo = 1;
            string menuLixosBorda = "###############################";

            System.Console.WriteLine(menuLixosBorda);
            System.Console.WriteLine("#                            #");
            System.Console.WriteLine("#           Lixos            #");
            System.Console.WriteLine("#                            #");
            System.Console.WriteLine(menuLixosBorda);

            foreach (var lixo in lixos)
            {
                System.Console.WriteLine($"{codigo++}");
            }
        }
    }
}
