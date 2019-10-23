using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class SacoCafe: Lixo, IOrganico
    {
        public string MandarCompostagem()
        {
            return this.GetType().Name;
        }
    }
}