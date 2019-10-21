using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Latinha : IMetal
    {
        public bool ReciclarMetal()
        {
            System.Console.WriteLine("Lixeira: Metal");
            System.Console.WriteLine("  Cor:   Amarela");
            return true;
        }
    }
}