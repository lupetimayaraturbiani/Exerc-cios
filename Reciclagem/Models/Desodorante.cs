using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Desodorante : Lixo, IDescarteEspecial
    {
        public string ReciclarEspecial()
        {
            return this.GetType().Name;
        }
    }
}