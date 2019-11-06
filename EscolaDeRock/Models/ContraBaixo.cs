using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class ContraBaixo : InstrumentoMusical, IPercurssao, IHarmonia
    {
        public bool ManterORitmo()
        {
            System.Console.WriteLine("Mantedo o ritmo do Contrabaixo.");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do Contrabaixo");
            return true;
        }
    }
}