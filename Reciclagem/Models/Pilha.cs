using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Pilha: Lixo, IDescarteEspecial
    {
        public string ReciclarEspecial()
        {
            return this.GetType().Name;
        }
    }
}