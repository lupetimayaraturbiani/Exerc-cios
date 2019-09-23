using System;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {   string opcao = "";

            Console.WriteLine("Calcule area");
            Console.WriteLine("1 - Para quadrado");    
            Console.WriteLine("2 - Para triângulo");
            Console.WriteLine("3 - Para círculo");
            Console.WriteLine("4 - Para trapézio");
            Console.WriteLine("5 - Para retângulo");
            Console.WriteLine("6 - Para losango");
            opcao = Console.ReadLine();

            switch (opcao) {
                case "2":
                Console.WriteLine("Área do Triangulo");
                Console.Write("Entre com a base ");
                double basetri = double.Parse(Console.ReadLine());
                Console.Write("Entre com a altura ");
                double altri = double.Parse(Console.ReadLine());
                double areatri = (basetri * altri) / 2;
                Console.WriteLine("A área do triângulo é: " +areatri);
                break;

                case "1":
                Console.WriteLine("Área do quadrado");
                Console.Write("Qual o lado do quadrado? ");
                double ladoquad = double.Parse(Console.ReadLine());
                double areaquad = ladoquad * ladoquad;
                Console.WriteLine("A área do quadrado é:" + areaquad);
                break;

                case "3":
                Console.WriteLine("Área do círculo");
                Console.Write("Qual o valor do pi? ");
                double pi = double.Parse(Console.ReadLine());
                Console.Write("Qual o valor do raio? ");
                double raio = double.Parse(Console.ReadLine());
                double areacir = pi * raio * raio;
                Console.WriteLine("A área do círculo é: " + areacir);
                break;

                case "4":
                Console.WriteLine("Área do trapézio");
                Console.Write("Entre com o valor da base menor: ");
                double basemenor = double.Parse(Console.ReadLine());
                Console.Write("Entre com o valor da base menor: ");
                double basemaior = double.Parse(Console.ReadLine());
                Console.Write("Entre com o valor da altura: ");
                double altrap = double.Parse(Console.ReadLine());
                double areatrap = (basemenor + basemaior) * altrap / 2;
                Console.WriteLine("A área do trapézio é: " + areatrap);
                break;

                case "5":
                Console.WriteLine("Área do retângulo");
                Console.Write("Entre com o valor da base: ");
                double baseret = double.Parse(Console.ReadLine());
                Console.Write("Entre com o valor da altura");
                double altret = double.Parse(Console.ReadLine());
                double arearet = baseret * altret;
                Console.WriteLine("A área do retângulo é: " + arearet);
                break;

                case "6":
                Console.WriteLine("Área do losango");
                Console.Write("Coloque o valor da diagonal maior: ");
                double dialos = double.Parse(Console.ReadLine());
                Console.Write("Coloque o valor da diagonal menor: ");
                double dialos2 = double.Parse(Console.ReadLine());
                double arealos = dialos * dialos2 / 2;
                Console.WriteLine("A área do losango é: " + arealos);
                break;

                
            }
        }
        }
    }

