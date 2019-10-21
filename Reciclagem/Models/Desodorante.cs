using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Desodorante : IDescarteEspecial
    {
        public bool ReciclarEspecial()
        {
            System.Console.WriteLine("Lixeira: Descarte Especial");
            System.Console.WriteLine("Cor:     Cinza");
            return true;
        }
    }
}