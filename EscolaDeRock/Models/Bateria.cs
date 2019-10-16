using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Bateria : InstrumentoMusical, IPercurssao
    {
        public bool ManterORitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo da Bateria.");
            return true;
        }
    }
}