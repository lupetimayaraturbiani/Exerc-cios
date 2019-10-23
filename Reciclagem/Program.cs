using Reciclagem.Interfaces;
using Reciclagem.Models;
using System;
using System.Linq;

namespace Reciclagem
{
    enum LixosEnum : int
    {
        Desodorante,
        Frasco_Perfume,
        Garrafa_PET,
        Guardanapo,
        Latinha,
        Papelão,
        Pilha,
        Saco_Café
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
            
            bool quersair = false;
            do
            {
            string[] itensMenu = Enum.GetNames(typeof(LixosEnum));

                ExibirMenuDeLixos();

                System.Console.WriteLine("Digite o número correspondente ao lixo: ");
                int codigo = int.Parse(Console.ReadLine());
                Reciclar(Lixeira.lixos[codigo]);
            }while ( !quersair);
            
        }

        public static void Reciclar(Lixo lixo)
        {
            Type tipoLixo = lixo.GetType().GetInterfaces().FirstOrDefault();

            if (tipoLixo.Equals(typeof(IPapel)))
            {
                IPapel lixoConvertido = (IPapel) lixo;
                Console.BackgroundColor = ConsoleColor.Blue;
                System.Console.WriteLine($"{lixoConvertido.ReciclarPapel()} deve ir para a lixeira Azul.");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IPlastico)))
            {
                IPlastico lixoConvertido = (IPlastico) lixo;
                Console.BackgroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"{lixoConvertido.ReciclarPlastico()} deve ir para a lixeira Vermelha.");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IMetal)))
            {
                IMetal lixoConvertido = (IMetal) lixo;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine($"{lixoConvertido.ReciclarMetal()} deve ir para a lixeira Amarela.");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IVidro)))
            {
                IVidro lixoConvertido = (IVidro) lixo;
                Console.BackgroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"{lixoConvertido.ReciclarVidro()} dever ir para a lixeira Verde.");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IOrganico)))
            {
                IOrganico lixoConvertido = (IOrganico) lixo;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                System.Console.WriteLine($"{lixoConvertido.MandarCompostagem()} deve ir para a composteira.");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IDescarteEspecial)))
            {
                IDescarteEspecial lixoConvertido = (IDescarteEspecial) lixo;
                Console.BackgroundColor = ConsoleColor.DarkGray;
                System.Console.WriteLine($"{lixoConvertido.ReciclarEspecial()} deve ir para o descarte especial.");
            }
            else
            {
                System.Console.WriteLine("Lixo não identificado");
            }
        }
        
        
        public static void ExibirMenuDeLixos()
        {
            var lixos = Enum.GetNames(typeof(LixosEnum));
            int codigo = 1;
            string menuLixosBorda = "###############################";

            System.Console.WriteLine(menuLixosBorda);
            System.Console.WriteLine("#                            #");
            System.Console.WriteLine("#         Reciclagem         #");
            System.Console.WriteLine("#     - Menu de Lixos -      #");
            System.Console.WriteLine(menuLixosBorda);

            foreach (string lixo in lixos)
            {
                System.Console.WriteLine($"{codigo++}.{TratarTituloMenu(lixo)}");
            }
        }

        public static string TratarTituloMenu(string titulo)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titulo.Replace("_", " ").ToLower());
        }
    }
}
