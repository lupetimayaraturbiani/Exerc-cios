using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class FrascoPerfume : IVidro
    {
        public bool ReciclarVidro()
        {
            System.Console.WriteLine("Lixeira : Vidro");
            System.Console.WriteLine("  Cor:    Verde");
            return true;
        }
    }
}