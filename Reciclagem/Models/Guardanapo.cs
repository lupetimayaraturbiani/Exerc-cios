using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Guardanapo: Lixo, IPapel
    {
        public string ReciclarPapel()
        {
            return this.GetType().Name;
        }
    }
}