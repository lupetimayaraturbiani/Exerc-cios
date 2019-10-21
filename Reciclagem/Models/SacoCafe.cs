using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class SacoCafe
    {
        public bool ReciclarOrganico()
        {
            System.Console.WriteLine("Lixeira: Orgânico");
            return true;
        }
    }
}