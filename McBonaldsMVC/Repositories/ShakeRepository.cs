using System.Collections.Generic;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class ShakeRepository
    {
        private const string PATH = "Database/Shake.csv";

        public List<Shake> ObterTodos()
        {
            List<ShakeRepository> shakes = new List<ShakeRepository>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                Shake s = new Shake();
                string[] dados = linha.Split(";");
                s.Nome = dados[0];
                s.Preco = double.Parse(dados[1]);
                shakes.Add(s);
            }

            
        }
    }
}