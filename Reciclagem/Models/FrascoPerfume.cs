using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class FrascoPerfume : Lixo, IVidro
    {
        public string ReciclarVidro()
        {
            return this.GetType().Name;
        }
    }
}