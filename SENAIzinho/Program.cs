using System;

namespace SENAIzinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int limiteAlunos = 100;
            int limiteSalas = 10;
            Aluno[] alunos = new string [100];
            Sala[] salas = new string [10];
            int alunosCadastrados;
            int salasCadastradas;
            bool querSair;

        }

        public void AlunoCadastrarAluno(int limiteAlunos, int alunosCadastrados){
            if(alunosCadastrados < limiteAlunos){
                System.Console.Write("Digite o nome do aluno: ");
                string nome = Console.ReadLine();
                System.Console.Write("Digite a idade do aluno: ");
                DateTime DataNascimento = DateTime.Parse(Console.ReadLine());
                
            }else {
                System.Console.WriteLine("Não há vagas suficientes para o cadastro do aluno.");
            }
        }
    }
}
