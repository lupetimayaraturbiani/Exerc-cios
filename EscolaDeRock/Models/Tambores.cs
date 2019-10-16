using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Tambores: InstrumentoMusical, IPercurssao
    {
        public bool ManterORitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo dos Tambores.");
            return true;
        }
    }
}