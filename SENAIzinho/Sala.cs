namespace SENAIzinho
{
    public class Sala
    {
        public int capacidadeAtual;
        public int capacidadeTotal;
        public int numeroSala;
        public string[] Alunos = new string [10];


        public Sala(int numSala,int capaTotal){
            this.numeroSala = numSala ;
            this.capacidadeTotal = capaTotal;
        }

        public string AlocarAluno(string Nome){
            if(capacidadeAtual <= capacidadeTotal)
            {
                Nome = Alunos[0];
                System.Console.WriteLine($"O aluno/a {Nome} foi matriculado/a com sucesso!");
            } else {
                System.Console.WriteLine("Não foi possível matricular o/a aluno/a.");
            }
        }

        public string RemoverAluno(string Nome){
            if(Nome == Alunos)
            {
                Nome = Alunos;
                return System.Console.WriteLine($"O aluno/a {Nome} foi removido/a com sucesso!");
            }else {
                return System.Console.WriteLine("O aluno/a não se encontra matriculado/a nessa sala ou a mesma está vazia.");
            }
        }

        public string MostrarAluno(string Alunos){
            Nome = Alunos[0];
        }
    }
}