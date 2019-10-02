using System;
using MateODragão.Models;

namespace MateODragão
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jogadornaodesistiu = true;
            do {

                Console.Clear();
                System.Console.WriteLine("==============================");
                System.Console.WriteLine("        Mate o Dragão         ");
                System.Console.WriteLine("==============================");

                System.Console.WriteLine(" 1 - Iniciar jogo");
                System.Console.WriteLine(" 0 - Sair do jogo");

                string opcaojogador = Console.ReadLine();

                switch (opcaojogador)
                {
                    case "1":
                        Console.Clear();
                        Guerreiro guerreiro = new Guerreiro();
                        guerreiro.Nome = "Jude";
                        guerreiro.Sobrenome = "Westfall";
                        guerreiro.CidadeNatal = "Pompeia";
                        guerreiro.DataNascimento = DateTime.Parse("06/11/1721");
                        guerreiro.FerramentaAtaque = "Espada";
                        guerreiro.FerramentaProtecao = "Capa mágica";
                        guerreiro.Forca = 2;
                        guerreiro.Destreza = 2;
                        guerreiro.Inteligencia = 4;
                        guerreiro.Vida = 20;

                        Dragao dragao = new Dragao();
                        dragao.Nome = "George";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;

                        /*INICIO - Primeiro Diálogo*/
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: {dragao.Nome}, seu louco! Vim-lhe derrotar-lhe");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Humano tolinho. Quem pensas que és?");

                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte EMTER para prosseguir");
                        Console.ReadLine();
                        /*FIM - Primeiro Diálogo */

                        /*INICIO - Primeiro Diálogo */
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome} da casa {guerreiro.Sobrenome}, ó criatura morfética");
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Vim de {guerreiro.CidadeNatal} para derrotar-te e mostrar meu valor");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: QUEM? DE ONDE? Bom, que seja...fritar-te-ei e devorar-te-ei, primata insolente!");

                        System.Console.WriteLine("BRUNO: Tá na hora do Show!");

                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte o ENTER para proceguir");
                        Console.ReadLine();

                        /*FIM - Primeiro Diálogo */
                        Console.Clear();

                        bool jogadoratacaprimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        int poderataqueguerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;
                        bool jogadornaocorreu = true;

                        if(jogadoratacaprimeiro){
                            System.Console.WriteLine("****Turno do Jogador****");
                            System.Console.WriteLine("Escolha uma ação:");
                            System.Console.WriteLine("1 - Atacar");
                            System.Console.WriteLine("2 - Fugir");

                            string opcaobatalhajogador = Console.ReadLine();

                            switch (opcaobatalhajogador)
                            {
                                case "1":
                                    Random geradornumeroaleatorio = new Random();
                                    int numeroaleatoriojogador = geradornumeroaleatorio.Next(0,5);
                                    int numeroaleatoriodragao = geradornumeroaleatorio.Next(0,5);
                                    int guerreirodestrezatotal = guerreiro.Destreza + numeroaleatoriojogador;
                                    int dragaodestrezatotal = dragao.Destreza + numeroaleatoriodragao;

                                    if(guerreirodestrezatotal > dragaodestrezatotal){
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa, lagartixa gigante!!");
                                        dragao.Vida -= poderataqueguerreiro + 5;
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                    }else
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: penakkk");
                                    }

                                break;
                                case "2":
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Adeus consagrado");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: brother tava no papo");
                                    jogadornaocorreu = false;
                                break;
                            }
                        }
                        
                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();

                        while (guerreiro.Vida > 0 && dragao.Vida > 0 && jogadornaocorreu )
                        {
                            Console.Clear();
                            System.Console.WriteLine("*** Turno Dragão ***");
                            Random geradornumeroaleatorio = new Random();
                                    int numeroaleatoriojogador = geradornumeroaleatorio.Next(0,5);
                                    int numeroaleatoriodragao = geradornumeroaleatorio.Next(0,5);
                                    int guerreirodestrezatotal = guerreiro.Destreza + numeroaleatoriojogador;
                                    int dragaodestrezatotal = dragao.Destreza + numeroaleatoriodragao;

                                    if(dragaodestrezatotal > guerreirodestrezatotal ){
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Ops, acho que foi em você não?");
                                        guerreiro.Vida -= dragao.Forca;
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                    }else
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: uau ein agora acerto lagarta roxa");
                                    }
                                    
                                    System.Console.WriteLine();
                                    System.Console.WriteLine("Aperte ENTER para prosseguir");
                                    Console.ReadLine();

                                    Console.Clear();

                                    System.Console.WriteLine("****Turno do Jogador****");
                                    System.Console.WriteLine("Escolha uma ação:");
                                    System.Console.WriteLine("1 - Atacar");
                                    System.Console.WriteLine("2 - Fugir");

                                    string opcaobatalhajogador = Console.ReadLine();

                                    switch (opcaobatalhajogador)
                                    {
                                        case "1":
                                             geradornumeroaleatorio = new Random();
                                             numeroaleatoriojogador = geradornumeroaleatorio.Next(0,5);
                                             numeroaleatoriodragao = geradornumeroaleatorio.Next(0,5);
                                             guerreirodestrezatotal = guerreiro.Destreza + numeroaleatoriojogador;
                                             dragaodestrezatotal = dragao.Destreza + numeroaleatoriodragao;

                                            if(guerreirodestrezatotal > dragaodestrezatotal){
                                                System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa, lagartixa gigante!!");
                                                dragao.Vida -= poderataqueguerreiro + 5;
                                                System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                                System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                            }else
                                            {
                                                System.Console.WriteLine($"{dragao.Nome.ToUpper()}: penakkk");
                                            }

                                        break;
                                        case "2":
                                            System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Adeus consagrado");
                                            System.Console.WriteLine($"{dragao.Nome.ToUpper()}: brother tava no papo");
                                            jogadornaocorreu = false;
                                        break;
                                    }
                                    
                        }

                        break;
                    case "0":
                        jogadornaodesistiu = false;
                        System.Console.WriteLine("GAME OVER");
                        break;

                    default:
                        System.Console.WriteLine("Comando inválido");
                        break;
                }
            } while (jogadornaodesistiu);
        }
    }
}
