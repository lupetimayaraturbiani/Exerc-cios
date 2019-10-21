using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class GarrafaPet : IPlastico
    {
        public bool ReciclarPlastico()
        {
            System.Console.WriteLine("Lixeira: Plasticos");
            System.Console.WriteLine("Cor: Vermelho");
            return true;
        }
    }
}