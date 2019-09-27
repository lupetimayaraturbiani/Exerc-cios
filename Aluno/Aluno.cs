using System;

namespace Aluno
{    
    public class Aluno{
        //propriedades
        public string Nome{get;set;}
        public string Curso{get;set;}
        public string Cpf{get;set;}
        public int[] Notas;

        //construtor
        public Aluno(string Nome, string Cpf){
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Curso = Curso;
        }

        public Aluno(string Nome, string Cpf, string Curso){
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Curso = Curso;
            Notas = new int [4];
        }

        //métodos de acesso
        public int[] getNotas(){return Notas;}

        public void setNotas(int bi, int nota){
            int i = bi - 1;
            if((i < 0) || (i > 3)){
                //condição de erro;
                throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 1 and 4");
            } else if (Notas < 0 || Notas > 10){

            }
        }
    }
}