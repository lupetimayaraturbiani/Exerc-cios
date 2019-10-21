using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Papelao : IPapel
    {
        public bool ReciclarPapel()
        {
            System.Console.WriteLine("Lixeira: Papel");
            System.Console.WriteLine("  Cor:   Azul");
            return true;
        }
    }
}