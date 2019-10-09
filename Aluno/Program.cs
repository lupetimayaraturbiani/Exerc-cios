using System;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
        Aluno aluno1 = new Aluno("Alexander", "123.456.789-00", "Medicina");
        Aluno aluno2 = new Aluno ("Cesar", "987.654.321-99","Prog1");

        Console.WriteLine("Nome: " + aluno1.Nome);
        Console.WriteLine("Cpf: " + aluno1.Cpf);
        Console.WriteLine("Cpf: " + aluno1.Curso);
        Console.WriteLine("Nome: " + aluno2.Nome);
        Console.WriteLine("Cpf: " + aluno2.Cpf);
        Console.WriteLine("Cpf: " + aluno2.Curso);

        Console.Write("Entre com o nome: ");
        string nome = Console.ReadLine();
        Console.Write("Entre com o CPF: ");
        string cpf = Console.ReadLine();
        Console.Write("Entre com o curso: ");
        string curso = Console.ReadLine();
        Console.Write("Entre com a nota: ");
        int nota = int.Parse(Console.ReadLine());
        Console.Write("Entre com o bimestre: ");
        int bimestre = int.Parse(Console.ReadLine());
        Aluno aluno3 = new Aluno(nome,cpf,curso);
        aluno3.setNotas(bimestre,nota);

        Console.WriteLine("Nome: " + aluno3.Nome);
        Console.WriteLine("CPF: " + aluno3.Cpf);
        Console.WriteLine("Curso: " + aluno3.Curso);
        Console.WriteLine("Notas: ");
        foreach(int n in aluno3.getNotas()){
            Console.Write(n + " ");
        }


        }
    }
}
