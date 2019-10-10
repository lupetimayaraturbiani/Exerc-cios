using System;

namespace SENAIzinho
{
    class Program
    {
        static void Main(string[] args)
        {
        int limiteAlunos = 10;
        int limiteSalas = 10;
        int totalAlunos = 100;
        Aluno[] alunos =  new Aluno[100];
        Sala[] salas = new Sala [10];
        int alunosCadastrados;
        int salasCadastradas;
        bool querSair;
        }

        public void CadastrarAluno(Aluno[] alunos,int totalAlunos, int alunosCadastrados) {
            if(alunosCadastrados < totalAlunos)
                {
                System.Console.WriteLine("Cadastro de Alunos");
                System.Console.WriteLine();
                System.Console.WriteLine("Nome:");
                string nome = Console.ReadLine();
                System.Console.WriteLine("Data de nascimento:");
                DateTime dtNascimento = DateTime.Parse(Console.ReadLine());

                Aluno novoAluno = new Aluno();
                novoAluno.Nome = nome;
                novoAluno.DataNascimento = dtNascimento;
                
                int index = 0;
                foreach(Aluno aluno in alunos)
                {
                if (aluno == null)
                {
                    alunos[index] = novoAluno;
                    break;
                }
                index++;
                }
                alunosCadastrados++;
            }
        }
    }
}
