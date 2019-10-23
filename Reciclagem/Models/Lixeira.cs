using System.Collections.Generic;

namespace Reciclagem.Models
{
    public class Lixeira
    {
        public static Dictionary<int, Lixo> lixos = new Dictionary<int, Lixo>()
        {
            { 1, new Desodorante() },
            { 2, new FrascoPerfume() },
            { 3, new GarrafaPet() },
            { 4, new Guardanapo() },
            { 5, new Latinha() },
            { 6, new Papelao() },
            { 7, new Pilha() },
            { 8, new SacoCafe() }
        };
    }
}