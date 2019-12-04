using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class TiposEventoRepository
    {
        private const string PATH = "Database/TiposEvento.csv";

        public double ObterPrecoDe(string nomeTiposEvento)
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if (item.Nome.Equals(nomeTiposEvento))
                {
                    preco = item.Preco;
                    break;
                }
            }

            return preco;
        }

        public List<TiposEvento> ObterTodos()
        {
            List<TiposEvento> tiposEvento = new List<TiposEvento>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                TiposEvento te = new TiposEvento();
                string[] dados = linha.Split(";");
                te.Nome = dados[0];
                te.Preco = double.Parse(dados[1]);
                tiposEvento.Add(te);
            }

            return tiposEvento;
        }
    }
}