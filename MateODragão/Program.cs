using System;
using MateODragão.Models;

namespace MateODragão
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jogadorNaoDesistiu = true;
            do
            {

                Console.Clear();
                System.Console.WriteLine("==============================");
                System.Console.WriteLine("        Mate o Dragão         ");
                System.Console.WriteLine("==============================");

                System.Console.WriteLine(" 1 - Iniciar jogo");
                System.Console.WriteLine(" 0 - Sair do jogo");

                string opcaoJogador = Console.ReadLine();

                switch (opcaoJogador)
                {
                    case "1":
                        Console.Clear();
                        
                        Guerreiro guerreiro = CriarGuerreiro();

                        Dragao dragao = CriarDragao();

                        /*INICIO - Primeiro Diálogo*/
                        CriarDialogo(guerreiro.Nome, $"{dragao.Nome}, seu louco! Vim-lhe derrotar-lhe");
                        CriarDialogo(dragao.Nome, $"Humano tolinho. Quem pensas que és?");

                        FinalizarDialogo();

                        /*FIM - Primeiro Diálogo */

                        /*INICIO - Segundo Diálogo */
                        CriarDialogo(guerreiro.Nome, $"Eu sou {guerreiro.Nome} da casa {guerreiro.Sobrenome}, ó criatura morfética");
                        CriarDialogo(guerreiro.Nome, $"Vim de {guerreiro.CidadeNatal} para derrotar-te e mostrar meu valor");
                        CriarDialogo(dragao.Nome, $"QUEM? DE ONDE? Bom, que seja...fritar-te-ei e devorar-te-ei, primata insolente!");

                        System.Console.WriteLine("BRUNO: Tá na hora do Show!");

                        FinalizarDialogo();
                        
                        /*FIM - Segundo Diálogo */
                        

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;
                        bool jogadornaocorreu = true;

                        if (jogadorAtacaPrimeiro)
                        {
                            System.Console.WriteLine("****Turno do Jogador****");
                            System.Console.WriteLine("Escolha uma ação:");
                            System.Console.WriteLine("1 - Atacar");
                            System.Console.WriteLine("2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador)
                            {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal)
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa, lagartixa gigante!!");
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                    }
                                    else
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

                        while (guerreiro.Vida > 0 && dragao.Vida > 0 && jogadornaocorreu)
                        {
                            Console.Clear();
                            System.Console.WriteLine("*** Turno Dragão ***");
                            Random geradorNumeroAleatorio = new Random();
                            int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                            int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                            int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                            int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                            if (dragaoDestrezaTotal > guerreiroDestrezaTotal)
                            {
                                System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Ops, acho que foi em você não?");
                                guerreiro.Vida -= dragao.Forca;
                                System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                            }
                            else
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

                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador)
                            {
                                case "1":
                                    geradorNumeroAleatorio = new Random();
                                    numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                    guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal)
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa, lagartixa gigante!!");
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                    }
                                    else
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

                        if (guerreiro.Vida <= 0)
                        {
                            System.Console.WriteLine("Você perdeu");
                        }
                        if (dragao.Vida <= 0)
                        {
                            System.Console.WriteLine("Você venceu!");
                        }

                        break;
                    case "0":
                        jogadorNaoDesistiu = false;
                        System.Console.WriteLine("GAME OVER");
                        break;

                    default:
                        System.Console.WriteLine("Comando inválido");
                        break;
                }
            } while (jogadorNaoDesistiu);
        }

        public static void CriarDialogo(string nome, string frase)
        {
            System.Console.WriteLine($"{nome.ToUpper()}:\n-{frase}");
        }

        public static void FinalizarDialogo()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Aperte o ENTER para prosseguir");
            Console.ReadLine();
            Console.Clear();
        }

        public static Guerreiro CriarGuerreiro()
        {
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

            return guerreiro;
        }

        public static Dragao CriarDragao()
        {
            Dragao dragao = new Dragao();
            dragao.Nome = "George";
            dragao.Forca = 5;
            dragao.Destreza = 1;
            dragao.Inteligencia = 3;
            dragao.Vida = 300;

            return dragao;
        }

    }
}
