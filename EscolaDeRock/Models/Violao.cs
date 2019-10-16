using System;
using EscolaDeRock.Interfaces;


namespace EscolaDeRock.Models
{
    public class Violao : InstrumentoMusical, IHarmonia, IMelodia, IPercurssao
    {
        public bool TocarAcordes()
        {
            Console.WriteLine("Tocar acordes de violão.");
            return true;
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo do violão.");
            return true;
        }

        public bool ManterORitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo do violão.");
            return true;
        }
    }
}